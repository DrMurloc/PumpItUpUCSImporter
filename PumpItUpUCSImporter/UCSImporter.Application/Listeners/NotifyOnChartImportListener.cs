using MediatR;
using UCSImporter.Application.Events;
using UCSImporter.Domain.Contracts;
using UCSImporter.Domain.Models;

namespace UCSImporter.Application.Listeners;

public sealed class NotifyOnChartImportListener : INotificationHandler<ChartsImportedEvent>
{
    private readonly IMessageClient _messageClient;

    public NotifyOnChartImportListener(IMessageClient messageClient)
    {
        _messageClient = messageClient;
    }

    public async Task Handle(ChartsImportedEvent notification, CancellationToken cancellationToken)
    {
        var message = string.Join("\n", notification.Charts.Select(GetChartDescription));
        await _messageClient.SendMessage(message, cancellationToken);
    }

    private string GetChartDescription(Chart chart)
    {
        return $@"{chart.Song.Name}: {chart.Type} {chart.Level} by {chart.Artist.Name} created on {chart.CreationDate}";
    }
}