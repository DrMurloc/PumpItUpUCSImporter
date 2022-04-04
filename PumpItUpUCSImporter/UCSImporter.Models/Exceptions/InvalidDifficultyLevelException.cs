namespace UCSImporter.Domain.Exceptions;

public sealed class InvalidDifficultyLevelException : Exception
{
    public InvalidDifficultyLevelException(string reason) : base($"Invalid Difficulty Level: {reason}")
    {
    }
}