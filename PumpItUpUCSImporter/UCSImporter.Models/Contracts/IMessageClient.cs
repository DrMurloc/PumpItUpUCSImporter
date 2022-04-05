using UCSImporter.Domain.Models;

namespace UCSImporter.Domain.Contracts;

public interface IMessageClient
{
    Task NotifyChartsImported(IEnumerable<Chart> charts, CancellationToken cancellationToken);
}