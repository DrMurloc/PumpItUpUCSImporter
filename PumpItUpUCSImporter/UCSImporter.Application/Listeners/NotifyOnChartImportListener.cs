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
        var result = $@"Chart: {chart.Song.Name} {chart.Type} {chart.Level}
Artist: {chart.Artist.Name}
Created on: {chart.CreationDate}";
        var info = chart.StepInfo;
        if (info != null)
        {
            result += $@"
{info.StepCount} Steps, {info.HoldCount} Holds, {info.JumpCount} Jumps";
            if (info.TripleCount > 0 || info.QuadCount > 0 || info.QuintPlusCount > 0)
            {
                result += @"
";
                if (info.TripleCount > 0)
                    result += $@"{info.TripleCount} Triples ";

                if (info.QuadCount > 0)
                    result += $@"{info.QuadCount} Quads ";

                if (info.QuintPlusCount > 0)
                    result += $@"{info.QuintPlusCount} Quintuple+ Steps";
            }

            if (info.SpeedChangeCount > 0)
                result += $@"
{info.SpeedChangeCount} Speed Changes, Maximum Change of {info.LargestSpeedChange} BPM";
        }

        result += $@"
https://piugame.com/bbs/board.php?bo_table=ucs&wr_id={chart.Id}";
        return result;
    }
}