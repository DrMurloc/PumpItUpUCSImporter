using Microsoft.Extensions.Logging;
using UCSImporter.Domain.Contracts;
using UCSImporter.Domain.ValueTypes;

namespace UCSImporter.Data.InMemory;

public sealed class LoggingMessageClient : IMessageClient
{
    private readonly ILogger _logger;

    public LoggingMessageClient(ILogger<LoggingMessageClient> logger)
    {
        _logger = logger;
    }

    public Task SendMessages(IEnumerable<Message> messages, CancellationToken cancellationToken = default)
    {
        foreach (var message in messages)
            _logger.LogInformation(message);
        return Task.CompletedTask;
    }
}