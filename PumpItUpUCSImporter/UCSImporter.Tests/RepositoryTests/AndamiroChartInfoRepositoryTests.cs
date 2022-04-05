using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoFixture;
using FakeItEasy;
using Microsoft.Extensions.Logging;
using UCSImporter.Data;
using UCSImporter.Data.Apis.Contracts;
using UCSImporter.Domain.ValueTypes;
using UCSImporter.Tests.Helpers;
using Xunit;

namespace UCSImporter.Tests.RepositoryTests;

public sealed class AndamiroChartInfoRepositoryTests
{
    private readonly Fixture _fixture = FixtureBuilder.Build();

    [Fact]
    public async Task SinglesRowsProperlyParseIntoInfo()
    {
        //TestData
        var chartString = PiuSiteTestData.SinglesPageData;
        var chartId = _fixture.Create<ChartId>();

        //Setup
        var api = A.Fake<IPiuGameSiteApi>();

        A.CallTo(() => api.GetChartFile((int)chartId, A<CancellationToken>.Ignored))
            .Returns(chartString);

        var repository = new AndamiroChartStepInfoRepository(api, A.Fake<ILogger<AndamiroChartStepInfoRepository>>());

        //Test

        var info = await repository.GetStepInfoForCharts(new[] { chartId });

        //Assert
        var result = info.Single();
        Assert.Equal(1, result.QuintPlusCount);
        Assert.Equal(104.34375, result.LargestSpeedChange);
        Assert.Equal(2, result.QuadCount);
        Assert.Equal(7, result.TripleCount);
        Assert.Equal(494, result.StepCount);
        Assert.Equal(54, result.HoldCount);
        Assert.Equal(71, result.JumpCount);
        Assert.Equal(4, result.SpeedChangeCount);
    }
}