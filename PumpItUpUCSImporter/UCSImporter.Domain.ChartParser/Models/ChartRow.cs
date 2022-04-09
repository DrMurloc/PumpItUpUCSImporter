namespace UCSImporter.Domain.ChartParser.Models;

public sealed class ChartRow
{
    private readonly ChartState _chartState;
    private readonly Pad _left;
    private readonly Pad _right;
    private ChartRow? _previous;

    public ChartRow(Pad left, Pad right, ChartState chartState)
    {
        _left = left;
        _right = right;
        _chartState = chartState;
    }

    public double SpeedChange => _previous == null ? 0.0 : Math.Abs(_previous._chartState.BPM - _chartState.BPM);
    public bool IsSpeedChange => SpeedChange > 1;
    public int PressedAtOnce => _left.PressedAtOnce + _right.PressedAtOnce;
    public bool HasHold => _left.HasHold || _right.HasHold;
    public bool HasStep => _left.HasStep || _right.HasStep;

    public bool IsHalfDouble => !_left.TopLeft.IsPressed && !_left.BottomLeft.IsPressed && !_right.TopRight.IsPressed &&
                                !_right.BottomRight.IsPressed;

    public bool IsQuarterDouble => IsHalfDouble && !_left.Center.IsPressed && !_right.Center.IsPressed;

    public void SetPreviousRow(ChartRow row)
    {
        if (_previous != null) throw new Exception("Previous row was already set");

        _previous = row;
    }
}