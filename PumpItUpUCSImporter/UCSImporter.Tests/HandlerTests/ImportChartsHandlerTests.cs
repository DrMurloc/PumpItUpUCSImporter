using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoFixture;
using FakeItEasy;
using MediatR;
using UCSImporter.Application.Commands;
using UCSImporter.Application.Events;
using UCSImporter.Application.Handlers;
using UCSImporter.Domain.Contracts;
using UCSImporter.Domain.Models;
using UCSImporter.Domain.ValueTypes;
using UCSImporter.Tests.Helpers;
using Xunit;

namespace UCSImporter.Tests.HandlerTests;

public sealed class ImportChartsHandlerTests
{
    private readonly Fixture _fixture = FixtureBuilder.Build();

    [Fact]
    public async Task ImportChartsDoesNotSaveOrNotifyIfNoNewChartsImported()
    {
        //Test Data
        var chart = _fixture.Create<Chart>();

        //Set up
        var newChartRepository = A.Fake<INewChartRepository>();
        var existingChartRepository = A.Fake<IExistingChartRepository>();
        var mediator = A.Fake<IMediator>();

        A.CallTo(() => newChartRepository.GetNewCharts(1, A<CancellationToken>.Ignored))
            .Returns(new[] { chart });

        A.CallTo(() => existingChartRepository.GetCharts(A<IEnumerable<ChartId>>.Ignored, A<CancellationToken>.Ignored))
            .Returns(new[] { chart });

        var handler = new ImportChartsHandler(existingChartRepository, newChartRepository, mediator);

        //Test
        await handler.Handle(new ImportChartsCommand(), CancellationToken.None);

        //Assert
        A.CallTo(() => mediator.Publish(A<ChartsImportedEvent>.Ignored,
                A<CancellationToken>.Ignored))
            .MustNotHaveHappened();

        A.CallTo(() =>
                existingChartRepository.AddCharts(A<IEnumerable<Chart>>.Ignored,
                    A<CancellationToken>.Ignored))
            .MustNotHaveHappened();
    }

    [Fact]
    public async Task ImportChartsGetsMultiplePages()
    {
        //Test Data
        var firstPageChart = _fixture.Create<Chart>();
        var secondPageChart = _fixture.Create<Chart>();

        //Set up
        var newChartRepository = A.Fake<INewChartRepository>();
        var existingChartRepository = A.Fake<IExistingChartRepository>();
        var mediator = A.Fake<IMediator>();

        A.CallTo(() => newChartRepository.GetNewCharts(1, A<CancellationToken>.Ignored))
            .Returns(new[] { firstPageChart });

        A.CallTo(() => newChartRepository.GetNewCharts(2, A<CancellationToken>.Ignored))
            .Returns(new[] { secondPageChart });

        var handler = new ImportChartsHandler(existingChartRepository, newChartRepository, mediator);

        //Test
        await handler.Handle(new ImportChartsCommand(), CancellationToken.None);

        //Assert
        A.CallTo(() => mediator.Publish(
                A<ChartsImportedEvent>.That.Matches(e =>
                    e.Charts.Count() == 2 && e.Charts.Contains(firstPageChart) && e.Charts.Contains(secondPageChart)),
                A<CancellationToken>.Ignored))
            .MustHaveHappenedOnceExactly();

        A.CallTo(() =>
                existingChartRepository.AddCharts(
                    A<IEnumerable<Chart>>.That.Matches(e =>
                        e.Count() == 2 && e.Contains(firstPageChart) && e.Contains(secondPageChart)),
                    A<CancellationToken>.Ignored))
            .MustHaveHappenedOnceExactly();
    }

    [Fact]
    public async Task ImportChartsIgnoresExistingCharts()
    {
        //Test Data
        var chart = _fixture.Create<Chart>();
        var olderChart = _fixture.Create<Chart>();

        //Set up
        var newChartRepository = A.Fake<INewChartRepository>();
        var existingChartRepository = A.Fake<IExistingChartRepository>();
        var mediator = A.Fake<IMediator>();

        A.CallTo(() => newChartRepository.GetNewCharts(1, A<CancellationToken>.Ignored))
            .Returns(new[] { chart, olderChart });

        A.CallTo(() =>
                existingChartRepository.GetCharts(A<IEnumerable<ChartId>>.That.Matches(e => e.Contains(olderChart.Id)),
                    A<CancellationToken>.Ignored))
            .Returns(new[] { olderChart });

        var handler = new ImportChartsHandler(existingChartRepository, newChartRepository, mediator);

        //Test
        await handler.Handle(new ImportChartsCommand(), CancellationToken.None);

        //Assert
        A.CallTo(() => mediator.Publish(A<ChartsImportedEvent>.That.Matches(e => e.Charts.Single().Equals(chart)),
                A<CancellationToken>.Ignored))
            .MustHaveHappenedOnceExactly();

        A.CallTo(() =>
                existingChartRepository.AddCharts(A<IEnumerable<Chart>>.That.Matches(c => c.Single().Equals(chart)),
                    A<CancellationToken>.Ignored))
            .MustHaveHappenedOnceExactly();
    }

    [Fact]
    public async Task ImportChartsSavesChartsAndFiresEvent()
    {
        //Test Data
        var chart = _fixture.Create<Chart>();

        //Set up
        var newChartRepository = A.Fake<INewChartRepository>();
        var existingChartRepository = A.Fake<IExistingChartRepository>();
        var mediator = A.Fake<IMediator>();

        A.CallTo(() => newChartRepository.GetNewCharts(1, A<CancellationToken>.Ignored))
            .Returns(new[] { chart });

        var handler = new ImportChartsHandler(existingChartRepository, newChartRepository, mediator);

        //Test
        await handler.Handle(new ImportChartsCommand(), CancellationToken.None);

        //Assert
        A.CallTo(() => mediator.Publish(A<ChartsImportedEvent>.That.Matches(e => e.Charts.Single().Equals(chart)),
                A<CancellationToken>.Ignored))
            .MustHaveHappenedOnceExactly();

        A.CallTo(() =>
                existingChartRepository.AddCharts(A<IEnumerable<Chart>>.That.Matches(c => c.Single().Equals(chart)),
                    A<CancellationToken>.Ignored))
            .MustHaveHappenedOnceExactly();
    }

    [Fact]
    public async Task ImportChartsStopsAfter30Charts()
    {
        //Test Data
        var chart = _fixture.Create<Chart>();

        //Set up
        var newChartRepository = A.Fake<INewChartRepository>();
        var existingChartRepository = A.Fake<IExistingChartRepository>();
        var mediator = A.Fake<IMediator>();

        A.CallTo(() => newChartRepository.GetNewCharts(A<int>.Ignored, A<CancellationToken>.Ignored))
            .Returns(new[] { chart });

        var handler = new ImportChartsHandler(existingChartRepository, newChartRepository, mediator);

        //Test
        await handler.Handle(new ImportChartsCommand(), CancellationToken.None);

        //Assert
        A.CallTo(() => mediator.Publish(A<ChartsImportedEvent>.That.Matches(e => e.Charts.Count() == 30),
                A<CancellationToken>.Ignored))
            .MustHaveHappenedOnceExactly();

        A.CallTo(() =>
                existingChartRepository.AddCharts(A<IEnumerable<Chart>>.That.Matches(c => c.Count() == 30),
                    A<CancellationToken>.Ignored))
            .MustHaveHappenedOnceExactly();
    }
}