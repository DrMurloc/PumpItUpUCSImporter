namespace UCSImporter.Domain.Exceptions;

public sealed class InvalidChartIdException : Exception
{
    public InvalidChartIdException(string reason) : base($"Invalid Chart ID: {reason}")
    {
    }
}