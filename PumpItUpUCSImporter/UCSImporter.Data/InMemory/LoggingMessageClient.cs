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

    public Task SendMessage(Message message, CancellationToken cancellationToken = default)
    {
        _logger.LogInformation(message);
        return Task.CompletedTask;
    }
}