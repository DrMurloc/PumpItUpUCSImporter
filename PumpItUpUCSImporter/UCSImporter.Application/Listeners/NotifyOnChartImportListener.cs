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
        var message = string.Join("\n\n", notification.Charts.Select(GetChartDescription));
        await _messageClient.SendMessage(message, cancellationToken);
    }

    private string GetChartDescription(Chart chart)
    {
        return $@"Chart: {chart.Song.Name} {chart.Type} {chart.Level}
Artist: {chart.Artist.Name}
Created on: {chart.CreationDate}
https://piugame.com/bbs/board.php?bo_table=ucs&wr_id={chart.Id}";
    }
}