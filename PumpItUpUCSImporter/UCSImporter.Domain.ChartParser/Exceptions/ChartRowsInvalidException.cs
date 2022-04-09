using UCSImporter.Domain.ChartParser.Models;

namespace UCSImporter.Domain.ChartParser.Exceptions;

public sealed class ChartRowsInvalidException : AggregateException
{
    internal ChartRowsInvalidException(ChartStepInfo parsedInfo, IEnumerable<RowParseError> errors) : base(
        $@"Errors when parsing chart: {string.Join(", ", errors.Select(e => e.RowString))}",
        errors.Select(e => e.Exception))
    {
        ParsedInfo = parsedInfo;
    }

    public ChartStepInfo ParsedInfo { get; }
}