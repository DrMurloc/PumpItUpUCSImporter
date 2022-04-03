using System;
using AutoFixture;
using UCSImporter.Domain.Enums;
using UCSImporter.Domain.Models;
using UCSImporter.Domain.ValueTypes;
using UCSImporter.Tests.Helpers;
using Xunit;

namespace UCSImporter.Tests.ModelTests;

public sealed class ChartTests
{
    private readonly Fixture _fixture = FixtureBuilder.Build();

    [Theory]
    [InlineData(5)]
    [InlineData(1)]
    [InlineData(100000)]
    public void ChartsWithSameIdAreEqual(int chartId)
    {
        var chart1 = new Chart(chartId, _fixture.Create<Song>(),
            _fixture.Create<ChartType>(),
            _fixture.Create<DifficultyLevel>(),
            _fixture.Create<StepArtist>(), _fixture.Create<DateOnly>());
        var chart2 = new Chart(chartId, _fixture.Create<Song>(),
            _fixture.Create<ChartType>(),
            _fixture.Create<DifficultyLevel>(),
            _fixture.Create<StepArtist>(), _fixture.Create<DateOnly>());

        Assert.Equal(chart1, chart2);
        Assert.True(chart2.Equals((object)chart1));
        Assert.True(chart1.Equals((object)chart2));
        Assert.Equal(chart1.GetHashCode(), chart2.GetHashCode());
    }
}