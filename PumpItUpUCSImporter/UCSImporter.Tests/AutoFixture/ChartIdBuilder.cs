using System;
using AutoFixture.Kernel;
using UCSImporter.Domain.ValueTypes;

namespace UCSImporter.Tests.AutoFixture;

internal class ChartIdBuilder : ISpecimenBuilder
{
    private static int _currentChartId = 1;

    public object Create(object request, ISpecimenContext context)
    {
        if (request is not Type type || type != typeof(ChartId))
            return new NoSpecimen();

        return ChartId.From(_currentChartId++);
    }
}