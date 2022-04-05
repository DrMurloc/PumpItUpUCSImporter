using UCSImporter.Data.Apis.Contracts;
using UCSImporter.Domain.Contracts;
using UCSImporter.Domain.Models;
using UCSImporter.Domain.ValueTypes;

namespace UCSImporter.Data;

public sealed class AndamiroChartStepInfoRepository : IChartStepInfoRepository
{
    private readonly IPiuGameSiteApi _api;

    public AndamiroChartStepInfoRepository(IPiuGameSiteApi api)
    {
        _api = api;
    }

    public async Task<IEnumerable<ChartStepInfo>> GetStepInfoForCharts(IEnumerable<ChartId> chartIds,
        CancellationToken cancellationToken = default)
    {
        foreach (var id in chartIds)
        {
            var info = await _api.GetChartFile(id, cancellationToken);
        }

        return new[] { new ChartStepInfo(chartIds.First(), 1) };
    }
}