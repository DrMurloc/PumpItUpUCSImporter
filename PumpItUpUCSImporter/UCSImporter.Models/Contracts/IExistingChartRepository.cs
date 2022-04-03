using UCSImporter.Domain.Models;
using UCSImporter.Domain.ValueTypes;

namespace UCSImporter.Domain.Contracts;

public interface IExistingChartRepository
{
    Task<IEnumerable<Chart>> GetCharts(IEnumerable<ChartId> chartIds, CancellationToken cancellationToken = default);
    Task AddCharts(IEnumerable<Chart> charts, CancellationToken cancellationToken = default);
}