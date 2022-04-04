using Microsoft.EntityFrameworkCore;
using UCSImporter.Data.Entities;
using UCSImporter.Data.Persistence;
using UCSImporter.Domain.Contracts;
using UCSImporter.Domain.Enums;
using UCSImporter.Domain.Models;
using UCSImporter.Domain.ValueTypes;

namespace UCSImporter.Data;

public sealed class CosmosExistingChartsRepository : IExistingChartRepository
{
    private readonly ChartDbContext _database;

    public CosmosExistingChartsRepository(ChartDbContext database)
    {
        _database = database;
    }

    public async Task<IEnumerable<Chart>> GetCharts(IEnumerable<ChartId> chartIds,
        CancellationToken cancellationToken = default)
    {
        var chartIdInts = chartIds.Select(id => (int)id).ToArray();
        return await _database.Chart.Where(c => chartIdInts.Contains(c.ChartId)).Select(c => new Chart(c.ChartId,
                new Song(c.SongName),
                Enum.Parse<ChartType>(c.ChartType), c.Level, new StepArtist(c.StepArtistName), c.UploadDate))
            .ToArrayAsync(cancellationToken);
    }

    public async Task AddCharts(IEnumerable<Chart> charts, CancellationToken cancellationToken = default)
    {
        var newEntities = charts.Select(c => new ChartEntity
        {
            ChartId = c.Id,
            ChartType = c.Type.ToString(),
            Level = c.Level,
            SongName = c.Song.Name,
            StepArtistName = c.Artist.Name,
            UploadDate = c.CreationDate
        });
        await _database.Chart.AddRangeAsync(newEntities, cancellationToken);
        await _database.SaveChangesAsync(cancellationToken);
    }
}