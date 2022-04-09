using UCSImporter.Domain.ChartParser.Models;
using UCSImporter.Domain.ValueTypes;

namespace UCSImporter.Domain.Contracts;

public interface IChartStepInfoRepository
{
    Task<IEnumerable<ChartStepInfo>> GetStepInfoForCharts(IEnumerable<ChartId> chartIds,
        CancellationToken cancellationToken = default);
}