namespace UCSImporter.Domain.Exceptions;

public sealed class InvalidNameException : Exception
{
    public InvalidNameException(string reason) : base($"Invalid Name: {reason}")
    {
    }
}