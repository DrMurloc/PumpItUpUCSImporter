using MediatR;
using UCSImporter.Application.Events;
using UCSImporter.Domain.Contracts;
using UCSImporter.Domain.Models;
using UCSImporter.Domain.ValueTypes;

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
        await _messageClient.SendMessages(notification.Charts.Select(GetChartDescription), cancellationToken);
    }

    private Message GetChartDescription(Chart chart)
    {
        return $@"Chart: {chart.Song.Name} {chart.Type} {chart.Level}
Artist: {chart.Artist.Name}
Created on: {chart.CreationDate}
https://piugame.com/bbs/board.php?bo_table=ucs&wr_id={chart.Id}";
    }
}