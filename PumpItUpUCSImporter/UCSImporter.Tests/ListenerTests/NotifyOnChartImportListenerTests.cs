using System.Threading;
using System.Threading.Tasks;
using AutoFixture;
using FakeItEasy;
using UCSImporter.Application.Events;
using UCSImporter.Application.Listeners;
using UCSImporter.Domain.Contracts;
using UCSImporter.Domain.Models;
using UCSImporter.Domain.ValueTypes;
using UCSImporter.Tests.Helpers;
using Xunit;

namespace UCSImporter.Tests.ListenerTests;

public sealed class NotifyOnChartImportListenerTests
{
    private readonly Fixture _fixture = FixtureBuilder.Build();

    [Fact]
    public async Task ChartToMessageMappingTest()
    {
        //Test Data
        var chart = _fixture.Create<Chart>();
        var chart2 = _fixture.Create<Chart>();

        var expected = $@"
{chart.Song.Name}: {chart.Type} {chart.Level} by {chart.Artist.Name} created on {chart.CreationDate}
{chart2.Song.Name}: {chart2.Type} {chart2.Level} by {chart2.Artist.Name} created on {chart2.CreationDate}";

        //Set Up
        var client = A.Fake<IMessageClient>();

        var listener = new NotifyOnChartImportListener(client);

        //Test

        await listener.Handle(new ChartsImportedEvent(new[] { chart, chart2 }), CancellationToken.None);

        //Assert
        A.CallTo(() => client.SendMessage(A<Message>.That.Matches(m => m == expected), A<CancellationToken>.Ignored))
            .MustHaveHappenedOnceExactly();
    }
}