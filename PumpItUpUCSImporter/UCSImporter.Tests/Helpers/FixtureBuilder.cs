using AutoFixture;
using UCSImporter.Tests.AutoFixture;

namespace UCSImporter.Tests.Helpers;

public static class FixtureBuilder
{
    public static Fixture Build()
    {
        var fixture = new Fixture();
        fixture.Customizations.Add(new ChartIdBuilder());
        fixture.Customizations.Add(new DifficultyLevelBuilder());
        fixture.Customizations.Add(new NameBuilder());
        fixture.Customizations.Add(new DateOnlyBuilder());
        return fixture;
    }
}