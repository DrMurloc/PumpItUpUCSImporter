namespace UCSImporter.Domain.Exceptions;

public sealed class InvalidMessageException : Exception
{
    public InvalidMessageException(string reason) : base($"Invalid Message: {reason}")
    {
    }
}