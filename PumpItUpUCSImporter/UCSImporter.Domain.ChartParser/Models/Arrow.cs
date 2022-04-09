using UCSImporter.Domain.ChartParser.Enums;

namespace UCSImporter.Domain.ChartParser.Models;

public sealed class Arrow
{
    public Arrow(ArrowState state)
    {
        State = state;
    }

    private ArrowState State { get; }

    public bool IsPressed => IsStep || IsHeld;
    public bool IsStep => State == ArrowState.Step || State == ArrowState.StartOfFreeze;

    public bool IsHeld => State == ArrowState.EndOfFreeze || State == ArrowState.Freeze ||
                          State == ArrowState.StartOfFreeze;
}