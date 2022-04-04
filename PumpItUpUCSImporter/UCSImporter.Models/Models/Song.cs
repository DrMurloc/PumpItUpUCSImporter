using UCSImporter.Domain.ValueTypes;

namespace UCSImporter.Domain.Models;

public sealed class Song
{
    public Song(Name name)
    {
        Name = name;
    }

    public Name Name { get; }
}