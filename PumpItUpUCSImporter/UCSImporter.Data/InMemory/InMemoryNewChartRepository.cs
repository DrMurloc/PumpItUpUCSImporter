using UCSImporter.Domain.Contracts;
using UCSImporter.Domain.Enums;
using UCSImporter.Domain.Models;

namespace UCSImporter.Data.InMemory;

public sealed class InMemoryNewChartRepository : INewChartRepository
{
    public Task<IEnumerable<Chart>> GetNewCharts(int page, CancellationToken cancellationToken = default)
    {
        if (page > 1) return Task.FromResult<IEnumerable<Chart>>(Array.Empty<Chart>());
        return Task.FromResult<IEnumerable<Chart>>(new[]
        {
            new Chart(1, new Song("Song"), ChartType.Double, 14, new StepArtist("Artist"),
                DateOnly.FromDateTime(DateTime.Now))
        });
    }
}