using Microsoft.EntityFrameworkCore;
using UCSImporter.Data.Entities;

namespace UCSImporter.Data.Persistence;

public sealed class ChartDbContext : DbContext
{
    public ChartDbContext(DbContextOptions<ChartDbContext> options) : base(options)
    {
    }

    public DbSet<ChartEntity> Chart { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChartEntity>().ToContainer("Chart")
            .HasPartitionKey(c => c.SongName)
            .HasNoDiscriminator();
    }
}