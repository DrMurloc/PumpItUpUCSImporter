using UCSImporter.Domain.ChartParser.Models;
using Xunit;

namespace UCSImporter.Tests.ModelTests;

public sealed class ChartInfoTests
{
    [Fact]
    public void HalfDoublesAreMarked()
    {
        //Test Data
        const string chartString = @"
....XX....
...X..X...
..X....X..
...X..X...
....XX....";
        //Test
        var chartInfo = ChartParser.ParseAndamiroChart(1, chartString);

        //Assert
        Assert.True(chartInfo.IsHalfDouble);
    }

    [Theory]
    [InlineData("X.........")]
    [InlineData(".........X")]
    [InlineData(".X........")]
    [InlineData("........X.")]
    [InlineData("........M.")]
    [InlineData(".W........")]
    public void ChartsWithArrowsOnEdgesAreNotHalfDoubles(string chartRow)
    {
        //Test
        var chartInfo = ChartParser.ParseAndamiroChart(1, chartRow);

        //Assert
        Assert.False(chartInfo.IsHalfDouble);
    }

    [Theory]
    [InlineData("X.........")]
    [InlineData(".........X")]
    [InlineData(".X........")]
    [InlineData("........X.")]
    [InlineData("..X.......")]
    [InlineData(".......X..")]
    [InlineData(".......M..")]
    [InlineData(".......W..")]
    public void ChartsWithArrowsOnEdgesOrCentersAreNotQuarterDoubles(string chartRow)
    {
        //Test
        var chartInfo = ChartParser.ParseAndamiroChart(1, chartRow);

        //Assert
        Assert.False(chartInfo.IsQuarterDouble);
    }

    [Fact]
    public void QuarterDoublesAreMarked()
    {
        //Test Data
        const string chartString = @"
...X......
....X.....
.....X....
......X...";
        //Test
        var chartInfo = ChartParser.ParseAndamiroChart(1, chartString);

        //Assert
        Assert.True(chartInfo.IsQuarterDouble);
    }
}