using UCSImporter.Domain.ValueTypes;

namespace UCSImporter.Domain.Contracts;

public interface IMessageClient
{
    Task SendMessages(IEnumerable<Message> message, CancellationToken cancellationToken = default);
}