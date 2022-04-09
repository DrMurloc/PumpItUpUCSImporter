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

    public int PressedAtOnce => _arrows.Values.Count(a => a.IsPressed);
    public bool HasHold => _arrows.Values.Any(a => a.IsHeld);
    public bool HasStep => _arrows.Values.Any(a => a.IsStep);
}