using System.Collections.Immutable;
using MediatR;
using UCSImporter.Application.Commands;
using UCSImporter.Domain.Contracts;
using UCSImporter.Domain.Models;

namespace UCSImporter.Application.Handlers;

public sealed class ImportChartsHandler : IRequestHandler<ImportChartsCommand>
{
    private readonly IExistingChartRepository _existingCharts;
    private readonly IMessageClient _messageClient;
    private readonly INewChartRepository _newCharts;
    private readonly IChartStepInfoRepository _stepInfoRepository;

    public ImportChartsHandler(IExistingChartRepository existingCharts,
        INewChartRepository newCharts,
        IChartStepInfoRepository stepInfoRepository,
        IMessageClient messageClient)
    {
        _existingCharts = existingCharts;
        _newCharts = newCharts;
        _stepInfoRepository = stepInfoRepository;
        _messageClient = messageClient;
    }

    public async Task<Unit> Handle(ImportChartsCommand request, CancellationToken cancellationToken)
    {
        var currentPage = 1;
        var newCharts = new List<Chart>();
        var checkedChartCount = 0;

        do
        {
            var charts = (await _newCharts.GetNewCharts(currentPage++, cancellationToken)).ToImmutableArray();

            if (!charts.Any()) break;

            checkedChartCount += charts.Length;

            var existingCharts = (await _existingCharts.GetCharts(charts.Select(c => c.Id), cancellationToken))
                .ToImmutableArray();

            newCharts.AddRange(charts.Where(c => !existingCharts.Contains(c)));
        } while (checkedChartCount < 30);

        if (!newCharts.Any()) return Unit.Value;

        var chartInfo =
            (await _stepInfoRepository.GetStepInfoForCharts(newCharts.Select(c => c.Id), cancellationToken))
            .ToDictionary(c => c.ChartId);

        foreach (var chart in newCharts.Where(chart => chartInfo.ContainsKey(chart.Id)))
            chart.ApplyStepInfo(chartInfo[chart.Id]);

        await _existingCharts.AddCharts(newCharts, cancellationToken);
        await _messageClient.NotifyChartsImported(newCharts, cancellationToken);
        return Unit.Value;
    }
}