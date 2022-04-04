using MediatR;
using UCSImporter.Domain.Models;

namespace UCSImporter.Application.Events;

public sealed class ChartsImportedEvent : INotification
{
    public ChartsImportedEvent(IEnumerable<Chart> charts)
    {
        Charts = charts;
    }

    public IEnumerable<Chart> Charts { get; }
}