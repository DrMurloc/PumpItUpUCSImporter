using MediatR;
using Microsoft.Extensions.DependencyInjection;
using UCSImporter.Application.Handlers;
using UCSImporter.Data;
using UCSImporter.Data.Apis;
using UCSImporter.Data.Apis.Contracts;
using UCSImporter.Domain.Contracts;

namespace UCSImporter.CompositionRoot;

public static class RegistrationExtensions
{
    public static IServiceCollection AddUCSImporterCore(this IServiceCollection builder)
    {
        return builder.AddMediatR(typeof(ImportChartsHandler).Assembly);
    }

    public static IServiceCollection AddUCSImporterInfrastructure(this IServiceCollection builder)
    {
        builder.AddSingleton<IExistingChartRepository, InMemoryExistingChartsRepository>()
            .AddSingleton<IMessageClient, InMemoryMessageClient>()
            .AddTransient<IPiuGameSiteApi, PiuGameSiteApi>()
            .AddTransient<INewChartRepository, AndamiroNewChartRepository>()
            .AddHttpClient<IPiuGameSiteApi, PiuGameSiteApi>(o =>
            {
                o.BaseAddress = new Uri("https://www.piugame.com");
            });

        return builder;
    }
}