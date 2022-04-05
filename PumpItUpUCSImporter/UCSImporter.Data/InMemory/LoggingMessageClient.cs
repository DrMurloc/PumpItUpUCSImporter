using Microsoft.Extensions.Logging;
using UCSImporter.Domain.Contracts;
using UCSImporter.Domain.Models;

namespace UCSImporter.Data.InMemory;

public sealed class LoggingMessageClient : IMessageClient
{
    private readonly ILogger _logger;

    public LoggingMessageClient(ILogger<LoggingMessageClient> logger)
    {
        _logger = logger;
    }

    public Task NotifyChartsImported(IEnumerable<Chart> charts, CancellationToken cancellationToken)
    {
        foreach (var chart in charts) _logger.LogInformation($"Imported {chart.Id}");
        return Task.CompletedTask;
    }
}