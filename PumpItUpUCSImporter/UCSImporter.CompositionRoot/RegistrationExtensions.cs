using MediatR;
using Microsoft.Extensions.DependencyInjection;
using UCSImporter.Application.Handlers;

namespace UCSImporter.CompositionRoot;

public static class RegistrationExtensions
{
    public static IServiceCollection AddUCSImporterCore(this IServiceCollection builder)
    {
        builder.AddMediatR(typeof(ImportChartsHandler).Assembly);
    }
}