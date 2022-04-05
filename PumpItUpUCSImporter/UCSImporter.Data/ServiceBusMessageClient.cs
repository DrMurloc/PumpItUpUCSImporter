using Azure.Messaging.ServiceBus;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using UCSImporter.Data.Configuration;
using UCSImporter.Data.Dtos;
using UCSImporter.Domain.Contracts;
using UCSImporter.Domain.Models;

namespace UCSImporter.Data;

public sealed class ServiceBusMessageClient : IMessageClient
{
    private readonly ServiceBusConfiguration _configuration;

    public ServiceBusMessageClient(IOptions<ServiceBusConfiguration> options)
    {
        _configuration = options.Value;
    }

    public async Task NotifyChartsImported(IEnumerable<Chart> charts, CancellationToken cancellationToken)
    {
        var dtos = charts.Select(c => new UcsChartImportedDto
        {
            ChartId = c.Id,
            ChartType = c.Type.ToString(),
            CreationDate = c.CreationDate,
            DifficultyLevel = c.Level,
            HoldCount = c.StepInfo?.HoldCount ?? 0,
            JumpCount = c.StepInfo?.JumpCount ?? 0,
            LargestSpeedChange = c.StepInfo?.LargestSpeedChange ?? 0,
            QuadCount = c.StepInfo?.QuadCount ?? 0,
            QuintPlusCount = c.StepInfo?.QuintPlusCount ?? 0,
            SongName = c.Song.Name,
            SpeedChangeCount = c.StepInfo?.SpeedChangeCount ?? 0,
            StepArtistName = c.Artist.Name,
            StepCount = c.StepInfo?.StepCount ?? 0,
            TripleCount = c.StepInfo?.TripleCount ?? 0
        });
        var message = JsonConvert.SerializeObject(dtos);

        var client = new ServiceBusClient(_configuration.ConnectionString);
        var sender = client.CreateSender("ucs-imported");
        await sender.SendMessageAsync(new ServiceBusMessage(message), cancellationToken);
    }
}