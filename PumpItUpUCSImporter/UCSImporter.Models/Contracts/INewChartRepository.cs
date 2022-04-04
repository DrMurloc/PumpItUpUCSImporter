using UCSImporter.Domain.Models;

namespace UCSImporter.Domain.Contracts;

public interface INewChartRepository
{
    Task<IEnumerable<Chart>> GetNewCharts(int page, CancellationToken cancellationToken = default);
}