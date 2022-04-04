using System;
using System.Linq;
using System.Threading.Tasks;
using AutoFixture;
using Microsoft.EntityFrameworkCore;
using UCSImporter.Data;
using UCSImporter.Data.Entities;
using UCSImporter.Data.Persistence;
using UCSImporter.Domain.Models;
using UCSImporter.Tests.Helpers;
using Xunit;

namespace UCSImporter.Tests.RepositoryTests;

public sealed class ExistingChartsRepositoryTests : IDisposable
{
    private readonly ChartDbContext _database = InMemoryDbContextBuilder.Build();
    private readonly Fixture _fixture = FixtureBuilder.Build();

    public void Dispose()
    {
        _database.Chart.RemoveRange(_database.Chart.ToArray());
        _database.SaveChanges();
    }

    [Fact]
    public async Task RetrievingExistingChartsRetrievesById()
    {
        //Test Data
        var chart1 = _fixture.Create<Chart>();
        var chart2 = _fixture.Create<Chart>();
        var entities = new[]
        {
            new ChartEntity
            {
                ChartId = chart1.Id,
                ChartType = chart1.Type.ToString(),
                Level = chart1.Level,
                SongName = chart1.Song.Name,
                StepArtistName = chart1.Artist.Name,
                UploadDate = chart1.CreationDate
            },
            new ChartEntity
            {
                ChartId = chart2.Id,
                ChartType = chart2.Type.ToString(),
                Level = chart2.Level,
                SongName = chart2.Song.Name,
                StepArtistName = chart2.Artist.Name,
                UploadDate = chart2.CreationDate
            }
        };

        //Setup
        await _database.Chart.AddRangeAsync(entities);
        await _database.SaveChangesAsync();

        var repository = new CosmosExistingChartsRepository(_database);

        //Test
        var results = await repository.GetCharts(new[] { chart2.Id });

        //Assert
        var result = results.Single();

        Assert.Equal(chart2.Id, result.Id);
        Assert.Equal(chart2.CreationDate, result.CreationDate);
        Assert.Equal(chart2.Type, result.Type);
        Assert.Equal(chart2.Artist.Name, result.Artist.Name);
        Assert.Equal(chart2.Song.Name, result.Song.Name);
        Assert.Equal(chart2.Level, result.Level);
    }

    [Fact]
    public async Task SavingChartsPersistsEntity()
    {
        //Test Data
        var chart = _fixture.Create<Chart>();


        //Setup
        var repository = new CosmosExistingChartsRepository(_database);

        //Test
        await repository.AddCharts(new[] { chart });

        //Assert
        var entity = await _database.Chart.SingleAsync();
        Assert.Equal((int)chart.Id, entity.ChartId);
        Assert.Equal(chart.Song.Name, entity.SongName);
        Assert.Equal(chart.Artist.Name, entity.StepArtistName);
        Assert.Equal(chart.CreationDate, entity.UploadDate);
        Assert.Equal(chart.Type.ToString(), entity.ChartType);
        Assert.Equal((int)chart.Level, entity.Level);
    }
}