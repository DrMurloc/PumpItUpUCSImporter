using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FakeItEasy;
using Microsoft.Extensions.Logging;
using UCSImporter.Data;
using UCSImporter.Data.Apis.Contracts;
using UCSImporter.Domain.Enums;
using Xunit;

namespace UCSImporter.Tests.RepositoryTests;

public sealed class AndamiroNewChartsRepositoryTests
{
    [Fact]
    public async Task PageParsesIntoCharts()
    {
        //Test Data
        var pageResult = PiuSiteTestData.UcsPageData;

        //Set Up
        var client = A.Fake<IPiuGameSiteApi>();

        A.CallTo(() => client.GetUcsPage(A<int>.Ignored, A<CancellationToken>.Ignored))
            .Returns(pageResult);

        var repository = new AndamiroNewChartRepository(client, A.Fake<ILogger<AndamiroNewChartRepository>>());

        //Test
        var result = (await repository.GetNewCharts(1)).ToArray();

        //Assert
        var chart = result[0];


        Assert.Equal("Final Audition Ep. 2-1", chart.Song.Name);
        Assert.Equal("4/4/2022", chart.CreationDate.ToString());
        Assert.Equal("HAALL", chart.Artist.Name);
        Assert.Equal(ChartType.Double, chart.Type);
        Assert.Equal(10599, (int)chart.Id);

        chart = result[1];

        Assert.Equal("Bee", chart.Song.Name);
        Assert.Equal("4/4/2022", chart.CreationDate.ToString());
        Assert.Equal("acacia", chart.Artist.Name);
        Assert.Equal(ChartType.CoOp, chart.Type);
        Assert.Equal(10598, (int)chart.Id);

        chart = result[2];


        Assert.Equal("Nyarlathotep", chart.Song.Name);
        Assert.Equal("4/4/2022", chart.CreationDate.ToString());
        Assert.Equal("LIONRS", chart.Artist.Name);
        Assert.Equal(ChartType.DoublePerformance, chart.Type);
        Assert.Equal(10597, (int)chart.Id);

        chart = result[3];

        Assert.Equal("Mad5cience", chart.Song.Name);
        Assert.Equal("4/4/2022", chart.CreationDate.ToString());
        Assert.Equal("GOGENWOO2", chart.Artist.Name);
        Assert.Equal(ChartType.CoOp, chart.Type);
        Assert.Equal(10596, (int)chart.Id);


        chart = result[4];

        Assert.Equal("1949", chart.Song.Name);
        Assert.Equal("4/4/2022", chart.CreationDate.ToString());
        Assert.Equal("GOGENWOO2", chart.Artist.Name);
        Assert.Equal(ChartType.SinglePerformance, chart.Type);
        Assert.Equal(10595, (int)chart.Id);


        chart = result[5];

        Assert.Equal("Mad5cience", chart.Song.Name);
        Assert.Equal("4/4/2022", chart.CreationDate.ToString());
        Assert.Equal("GOGENWOO2", chart.Artist.Name);
        Assert.Equal(ChartType.Double, chart.Type);
        Assert.Equal(10594, (int)chart.Id);

        chart = result[6];

        Assert.Equal("Silhouette_Effect", chart.Song.Name);
        Assert.Equal("4/4/2022", chart.CreationDate.ToString());
        Assert.Equal("Noriter", chart.Artist.Name);
        Assert.Equal(ChartType.Single, chart.Type);
        Assert.Equal(10593, (int)chart.Id);

        chart = result[7];

        Assert.Equal("Mad5cience", chart.Song.Name);
        Assert.Equal("4/4/2022", chart.CreationDate.ToString());
        Assert.Equal("WISEY_", chart.Artist.Name);
        Assert.Equal(ChartType.Double, chart.Type);
        Assert.Equal(10592, (int)chart.Id);

        chart = result[8];

        Assert.Equal("District 1", chart.Song.Name);
        Assert.Equal("4/3/2022", chart.CreationDate.ToString());
        Assert.Equal("_AKA_", chart.Artist.Name);
        Assert.Equal(ChartType.Single, chart.Type);
        Assert.Equal(10591, (int)chart.Id);

        chart = result[9];

        Assert.Equal("Radetzky Can Can", chart.Song.Name);
        Assert.Equal("4/3/2022", chart.CreationDate.ToString());
        Assert.Equal("_AKA_", chart.Artist.Name);
        Assert.Equal(ChartType.Single, chart.Type);
        Assert.Equal(10590, (int)chart.Id);

        chart = result[10];

        Assert.Equal("Super Fantasy", chart.Song.Name);
        Assert.Equal("4/3/2022", chart.CreationDate.ToString());
        Assert.Equal("yjhgogoyoyo", chart.Artist.Name);
        Assert.Equal(ChartType.Single, chart.Type);
        Assert.Equal(10589, (int)chart.Id);

        chart = result[11];

        Assert.Equal("FFF", chart.Song.Name);
        Assert.Equal("4/3/2022", chart.CreationDate.ToString());
        Assert.Equal("Belics", chart.Artist.Name);
        Assert.Equal(ChartType.Single, chart.Type);
        Assert.Equal(10588, (int)chart.Id);

        chart = result[12];

        Assert.Equal("Violet Perfume", chart.Song.Name);
        Assert.Equal("4/3/2022", chart.CreationDate.ToString());
        Assert.Equal("SONG_HAON", chart.Artist.Name);
        Assert.Equal(ChartType.Double, chart.Type);
        Assert.Equal(10587, (int)chart.Id);

        chart = result[13];

        Assert.Equal("Super Capriccio", chart.Song.Name);
        Assert.Equal("4/3/2022", chart.CreationDate.ToString());
        Assert.Equal("SONG_HAON", chart.Artist.Name);
        Assert.Equal(ChartType.Single, chart.Type);
        Assert.Equal(10586, (int)chart.Id);

        chart = result[14];

        Assert.Equal("Phantom -Intermezzo-", chart.Song.Name);
        Assert.Equal("4/3/2022", chart.CreationDate.ToString());
        Assert.Equal("nQp1", chart.Artist.Name);
        Assert.Equal(ChartType.Double, chart.Type);
        Assert.Equal(10585, (int)chart.Id);

        /* To generate asserts:

        var asserts = string.Join(@"
", result.Select(c => $@"

Assert.Equal(""{c.Song.Name}"",chart.Song.Name);
Assert.Equal(""{c.CreationDate}"",chart.CreationDate.ToString());
Assert.Equal(""{c.Artist.Name}"",chart.Artist.Name);
Assert.Equal(ChartType.{c.Type},chart.Type);
Assert.Equal({c.Id},(int) chart.Id);"));*/
    }
}