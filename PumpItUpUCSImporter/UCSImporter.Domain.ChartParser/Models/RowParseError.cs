namespace UCSImporter.Domain.ChartParser.Models;

internal class RowParseError
{
    public RowParseError(string rowString, Exception exception)
    {
        RowString = rowString;
        Exception = exception;
    }

    public string RowString { get; }
    public Exception Exception { get; }
}