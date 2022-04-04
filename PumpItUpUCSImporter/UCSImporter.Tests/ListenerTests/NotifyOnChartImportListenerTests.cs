using System.Collections.Generic;
using System.Linq;
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

        var expected = new[]
        {
            $@"
Chart: {chart.Song.Name} {chart.Type} {chart.Level}
Artist: {chart.Artist.Name}
Created on: {chart.CreationDate}
https://piugame.com/bbs/board.php?bo_table=ucs&wr_id={chart.Id}",
            $@"
Chart: {chart2.Song.Name} {chart2.Type} {chart2.Level}
Artist: {chart2.Artist.Name}
Created on: {chart2.CreationDate}
https://piugame.com/bbs/board.php?bo_table=ucs&wr_id={chart2.Id}"
        };

        //Set Up
        var client = A.Fake<IMessageClient>();

        var listener = new NotifyOnChartImportListener(client);

        //Test

        await listener.Handle(new ChartsImportedEvent(new[] { chart, chart2 }), CancellationToken.None);

        //Assert
        A.CallTo(() =>
                client.SendMessages(A<IEnumerable<Message>>.That.Matches(m => expected.All(e => m.Contains(e))),
                    A<CancellationToken>.Ignored))
            .MustHaveHappenedOnceExactly();
    }
}