using System.Collections.Immutable;
using UCSImporter.Domain.ValueTypes;

namespace UCSImporter.Domain.Models;

public sealed class ChartStepInfo
{
    private readonly ImmutableArray<ChartRow> _rows;

    public ChartStepInfo(ChartId chartId, IEnumerable<ChartRow> rows)
    {
        ChartId = chartId;
        _rows = rows.ToImmutableArray();
    }

    public ChartId ChartId { get; }
    public int StepCount => _rows.Count(r => r.HasStep);
    public int HoldCount => _rows.Count(r => r.HasHold);
    public int JumpCount => _rows.Count(r => r.PressedAtOnce == 2);
    public int TripleCount => _rows.Count(r => r.PressedAtOnce == 3);
    public int QuadCount => _rows.Count(r => r.PressedAtOnce == 4);
    public int QuintPlusCount => _rows.Count(r => r.PressedAtOnce >= 5);
    public int SpeedChangeCount => _rows.Count(r => r.IsSpeedChange);
    public double LargestSpeedChange => _rows.Max(r => r.SpeedChange);
}