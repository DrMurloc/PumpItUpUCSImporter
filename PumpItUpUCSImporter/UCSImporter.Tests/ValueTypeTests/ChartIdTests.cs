using UCSImporter.Domain.Exceptions;
using UCSImporter.Domain.ValueTypes;
using Xunit;

namespace UCSImporter.Tests.ValueTypeTests;

public sealed class ChartIdTests
{
    [Fact]
    public void ChartIdLessThan1ThrowsException()
    {
        Assert.Throws<InvalidChartIdException>(() => ChartId.From(0));
    }

    [Theory]
    [InlineData(1)]
    [InlineData(1000)]
    public void ChartIdGreaterThan0IsFine(int id)
    {
        var chartId = ChartId.From(id);
        Assert.Equal(id, (int)chartId);
    }
}