using System.Collections.Immutable;
using UCSImporter.Domain.ChartParser.Enums;
using UCSImporter.Domain.ChartParser.Exceptions;

namespace UCSImporter.Domain.ChartParser.Models;

public static class ChartParser
{
    public static ChartStepInfo ParseAndamiroChart(int chartId, string chartFileString)
    {
        var (rows, errors) = ExtractRows(chartId, chartFileString);
        var info = new ChartStepInfo(chartId, rows);
        var errorsArray = errors.ToImmutableArray();
        if (errorsArray.Any()) throw new ChartRowsInvalidException(info, errorsArray);

        return info;
    }

    private static (IEnumerable<ChartRow>, IEnumerable<RowParseError>) ExtractRows(int chartId, string chart)
    {
        var rows = new List<ChartRow>();
        var errors = new List<RowParseError>();
        var chartState = new ChartState(0, 0, 0, 0);

        foreach (var rowString in chart.Replace("\r", "").Split("\n"))
            try
            {
                if (rowString.StartsWith(":Format", StringComparison.OrdinalIgnoreCase)
                    || rowString.StartsWith(":Mode", StringComparison.OrdinalIgnoreCase))
                    continue;

                if (rowString.StartsWith(":BPM=", StringComparison.OrdinalIgnoreCase))
                {
                    chartState = chartState.ApplyNewBpm(double.Parse(rowString.Replace(":BPM=", "")));
                    continue;
                }

                if (rowString.StartsWith(":Delay=", StringComparison.OrdinalIgnoreCase))
                {
                    chartState = chartState.ApplyNewDelay(double.Parse(rowString.Replace(":Delay=", "")));
                    continue;
                }

                if (rowString.StartsWith(":Beat=", StringComparison.OrdinalIgnoreCase))
                {
                    chartState = chartState.ApplyNewBeat(double.Parse(rowString.Replace(":Beat=", "")));
                    continue;
                }

                if (rowString.StartsWith(":Split=", StringComparison.OrdinalIgnoreCase))
                {
                    chartState = chartState.ApplyNewSplit(double.Parse(rowString.Replace(":Split=", "")));
                    continue;
                }

                var leftPad = new Pad(StateFromCharacter(rowString[0]), StateFromCharacter(rowString[1]),
                    StateFromCharacter(rowString[2]),
                    StateFromCharacter(rowString[3]),
                    StateFromCharacter(rowString[4]));
                var rightPad = rowString.Length == 10
                    ? new Pad(
                        StateFromCharacter(rowString[5]),
                        StateFromCharacter(rowString[6]),
                        StateFromCharacter(rowString[7]),
                        StateFromCharacter(rowString[8]),
                        StateFromCharacter(rowString[9]))
                    : new Pad(ArrowState.Nothing, ArrowState.Nothing, ArrowState.Nothing, ArrowState.Nothing,
                        ArrowState.Nothing);
                var newRow = new ChartRow(leftPad, rightPad, chartState);

                if (rows.Count > 0) newRow.SetPreviousRow(rows.Last());

                rows.Add(newRow);
            }
            catch (Exception e)
            {
                errors.Add(new RowParseError(rowString, e));
            }

        return (rows, errors);
    }

    private static ArrowState StateFromCharacter(char character)
    {
        switch (character)
        {
            case '.': return ArrowState.Nothing;
            case 'X': return ArrowState.Step;
            case 'M': return ArrowState.StartOfFreeze;
            case 'W': return ArrowState.EndOfFreeze;
            default: throw new Exception($"Unknown arrow state {character}");
        }
    }
}