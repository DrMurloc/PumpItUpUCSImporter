using UCSImporter.Domain.Enums;
using UCSImporter.Domain.ValueTypes;

namespace UCSImporter.Domain.Models;

public sealed class Chart : IEquatable<Chart>
{
    public Chart(ChartId id, Song song, ChartType type, DifficultyLevel level, StepArtist stepArtist,
        DateOnly creationDate)
    {
        Song = song;
        Type = type;
        Level = level;
        Artist = stepArtist;
        Id = id;
        CreationDate = creationDate;
    }

    public ChartId Id { get; }
    public Song Song { get; }
    public ChartType Type { get; }
    public DifficultyLevel Level { get; }
    public StepArtist Artist { get; }
    public DateOnly CreationDate { get; }

    public bool Equals(Chart? other)
    {
        return other is not null && Id.Equals(other.Id);
    }

    public override bool Equals(object? obj)
    {
        return obj is Chart chartOther && Equals(chartOther);
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}