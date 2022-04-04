using Microsoft.EntityFrameworkCore;
using UCSImporter.Data.Persistence;

namespace UCSImporter.Tests.Helpers;

public static class InMemoryDbContextBuilder
{
    public static ChartDbContext Build()
    {
        var builder = new DbContextOptionsBuilder<ChartDbContext>();
        builder.UseInMemoryDatabase("Chart");
        return new ChartDbContext(builder.Options);
    }
}