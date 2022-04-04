using System.Collections.Immutable;
using MediatR;
using UCSImporter.Application.Commands;
using UCSImporter.Application.Events;
using UCSImporter.Domain.Contracts;
using UCSImporter.Domain.Models;

namespace UCSImporter.Application.Handlers;

public sealed class ImportChartsHandler : IRequestHandler<ImportChartsCommand>
{
    private readonly IExistingChartRepository _existingCharts;
    private readonly IMediator _mediator;
    private readonly INewChartRepository _newCharts;

    public ImportChartsHandler(IExistingChartRepository existingCharts,
        INewChartRepository newCharts,
        IMediator mediator)
    {
        _existingCharts = existingCharts;
        _newCharts = newCharts;
        _mediator = mediator;
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
        await _existingCharts.AddCharts(newCharts, cancellationToken);
        await _mediator.Publish(new ChartsImportedEvent(newCharts), cancellationToken);
        return Unit.Value;
    }
}