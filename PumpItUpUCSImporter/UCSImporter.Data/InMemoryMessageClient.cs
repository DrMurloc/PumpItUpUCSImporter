using UCSImporter.Domain.Contracts;
using UCSImporter.Domain.ValueTypes;

namespace UCSImporter.Data;

public sealed class InMemoryMessageClient : IMessageClient
{
    private readonly List<Message> _messages = new();

    public Task SendMessage(Message message, CancellationToken cancellationToken = default)
    {
        _messages.Add(message);
        return Task.CompletedTask;
    }
}