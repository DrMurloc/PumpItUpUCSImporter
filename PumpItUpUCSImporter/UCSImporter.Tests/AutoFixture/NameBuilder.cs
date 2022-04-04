using System;
using AutoFixture.Kernel;
using UCSImporter.Domain.ValueTypes;

namespace UCSImporter.Tests.AutoFixture;

public sealed class NameBuilder : ISpecimenBuilder
{
    public object Create(object request, ISpecimenContext context)
    {
        if (request is not Type type || type != typeof(Name))
            return new NoSpecimen();

        return Name.From($"Name-{Guid.NewGuid()}");
    }
}