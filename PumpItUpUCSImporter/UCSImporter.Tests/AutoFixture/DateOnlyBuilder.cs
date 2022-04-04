using System;
using AutoFixture.Kernel;

namespace UCSImporter.Tests.AutoFixture;

public sealed class DateOnlyBuilder : ISpecimenBuilder
{
    private static DateOnly _nextDate = DateOnly.FromDateTime(DateTime.Now);

    public object Create(object request, ISpecimenContext context)
    {
        if (request is not Type type || type != typeof(DateOnly)) return new NoSpecimen();

        var result = _nextDate;
        _nextDate = _nextDate.AddDays(-1);
        return result;
    }
}