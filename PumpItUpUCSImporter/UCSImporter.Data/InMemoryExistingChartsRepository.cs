using UCSImporter.Domain.Contracts;
using UCSImporter.Domain.Models;
using UCSImporter.Domain.ValueTypes;

namespace UCSImporter.Data;

public sealed class InMemoryExistingChartsRepository : IExistingChartRepository
{
    private readonly List<Chart> _charts = new();

    public Task<IEnumerable<Chart>> GetCharts(IEnumerable<ChartId> chartIds,
        CancellationToken cancellationToken = default)
    {
        return Task.FromResult(_charts.Where(c => chartIds.Contains(c.Id)));
    }

    public Task AddCharts(IEnumerable<Chart> charts, CancellationToken cancellationToken = default)
    {
        _charts.AddRange(charts);
        return Task.CompletedTask;
    }
}