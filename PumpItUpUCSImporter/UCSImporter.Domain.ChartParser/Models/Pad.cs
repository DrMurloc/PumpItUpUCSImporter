using UCSImporter.Domain.ChartParser.Enums;

namespace UCSImporter.Domain.ChartParser.Models;

public sealed class Pad
{
    private readonly Dictionary<ArrowLocation, Arrow> _arrows;

    public Pad(ArrowState bottomLeftState, ArrowState topLeftState, ArrowState centerState, ArrowState topRightState,
        ArrowState bottomRightState)
    {
        _arrows = new Dictionary<ArrowLocation, Arrow>
        {
            [ArrowLocation.BottomLeft] = new(bottomLeftState),
            [ArrowLocation.TopLeft] = new(topLeftState),
            [ArrowLocation.Center] = new(centerState),
            [ArrowLocation.TopRight] = new(topRightState),
            [ArrowLocation.BottomRight] = new(bottomRightState)
        };
    }

    public Arrow TopLeft => _arrows[ArrowLocation.TopLeft];
    public Arrow BottomLeft => _arrows[ArrowLocation.BottomLeft];
    public Arrow Center => _arrows[ArrowLocation.Center];
    public Arrow TopRight => _arrows[ArrowLocation.TopRight];
    public Arrow BottomRight => _arrows[ArrowLocation.BottomRight];
    public int PressedAtOnce => _arrows.Values.Count(a => a.IsPressed);
    public bool HasHold => _arrows.Values.Any(a => a.IsHeld);
    public bool HasStep => _arrows.Values.Any(a => a.IsStep);
}