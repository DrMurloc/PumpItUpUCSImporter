using UCSImporter.Domain.ValueTypes;

namespace UCSImporter.Domain.Contracts;

public interface IMessageClient
{
    Task SendMessage(Message message, CancellationToken cancellationToken = default);
}