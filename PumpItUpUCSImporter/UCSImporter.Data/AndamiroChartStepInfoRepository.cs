using Microsoft.Extensions.Logging;
using UCSImporter.Data.Apis.Contracts;
using UCSImporter.Domain.ChartParser.Exceptions;
using UCSImporter.Domain.ChartParser.Models;
using UCSImporter.Domain.Contracts;
using UCSImporter.Domain.ValueTypes;

namespace UCSImporter.Data;

public sealed class AndamiroChartStepInfoRepository : IChartStepInfoRepository
{
    private readonly IPiuGameSiteApi _api;
    private readonly ILogger<AndamiroChartStepInfoRepository> _logger;

    public AndamiroChartStepInfoRepository(IPiuGameSiteApi api,
        ILogger<AndamiroChartStepInfoRepository> logger)
    {
        _api = api;
        _logger = logger;
    }

    public async Task<IEnumerable<ChartStepInfo>> GetStepInfoForCharts(IEnumerable<ChartId> chartIds,
        CancellationToken cancellationToken = default)
    {
        var result = new List<ChartStepInfo>();
        foreach (var id in chartIds)
        {
            var infoString = await _api.GetChartFile(id, cancellationToken);
            try
            {
                var info = ChartParser.ParseAndamiroChart(id, infoString);
                result.Add(info);
            }
            catch (ChartRowsInvalidException ex)
            {
                result.Add(ex.ParsedInfo);
                _logger.LogError(ex.Message, ex);
            }
        }

        return result;
    }
}