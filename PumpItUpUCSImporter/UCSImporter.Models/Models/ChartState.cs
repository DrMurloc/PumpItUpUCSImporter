namespace UCSImporter.Domain.Models;

public sealed class ChartState
{
    public ChartState(double bpm, double delay, double beat, double split)
    {
        BPM = bpm;
        Delay = delay;
        Beat = beat;
        Split = split;
    }

    public double BPM { get; }
    public double Delay { get; }
    public double Beat { get; }
    public double Split { get; }

    public ChartState ApplyNewBpm(double bpm)
    {
        return new ChartState(bpm, Delay, Beat, Split);
    }

    public ChartState ApplyNewDelay(double delay)
    {
        return new ChartState(BPM, delay, Beat, Split);
    }

    public ChartState ApplyNewBeat(double beat)
    {
        return new ChartState(BPM, Delay, beat, Split);
    }

    public ChartState ApplyNewSplit(double split)
    {
        return new ChartState(BPM, Delay, Beat, split);
    }
}