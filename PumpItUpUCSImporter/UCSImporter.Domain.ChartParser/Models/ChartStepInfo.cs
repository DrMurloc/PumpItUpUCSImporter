using System.Collections.Immutable;

namespace UCSImporter.Domain.ChartParser.Models;

public sealed class ChartStepInfo
{
    private readonly ImmutableArray<ChartRow> _rows;

    public ChartStepInfo(int chartId, IEnumerable<ChartRow> rows)
    {
        ChartId = chartId;
        _rows = rows.ToImmutableArray();
        foreach (var chartRow in _rows) ProcessRow(chartRow);
    }

    public int ChartId { get; }
    public int StepCount { get; private set; }
    public int HoldCount { get; private set; }
    public int JumpCount { get; private set; }
    public int TripleCount { get; private set; }
    public int QuadCount { get; private set; }
    public int QuintPlusCount { get; private set; }
    public int SpeedChangeCount { get; private set; }
    public double LargestSpeedChange { get; private set; }
    public bool IsHalfDouble { get; private set; } = true;
    public bool IsQuarterDouble { get; private set; } = true;

    private void ProcessRow(ChartRow row)
    {
        if (row.HasStep) StepCount++;

        if (row.HasHold) HoldCount++;

        if (row.PressedAtOnce == 2) JumpCount++;

        if (row.PressedAtOnce == 3) TripleCount++;

        if (row.PressedAtOnce == 4) QuadCount++;

        if (row.PressedAtOnce >= 5) QuintPlusCount++;

        if (row.IsSpeedChange) SpeedChangeCount++;

        if (row.SpeedChange > LargestSpeedChange) LargestSpeedChange = row.SpeedChange;

        if (!row.IsHalfDouble) IsHalfDouble = false;

        if (!row.IsQuarterDouble) IsQuarterDouble = false;
    }
}