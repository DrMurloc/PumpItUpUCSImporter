using UCSImporter.Domain.ValueTypes;

namespace UCSImporter.Domain.Models;

public sealed class ChartStepInfo
{
    public ChartStepInfo(ChartId chartId, int stepCount)
    {
        ChartId = chartId;
        StepCount = stepCount;
    }

    public ChartId ChartId { get; }
    public int StepCount { get; }
}