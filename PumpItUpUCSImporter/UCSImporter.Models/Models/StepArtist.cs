using UCSImporter.Domain.ValueTypes;

namespace UCSImporter.Domain.Models;

public sealed class StepArtist
{
    public StepArtist(Name name)
    {
        Name = name;
    }

    public Name Name { get; }
}