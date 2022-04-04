using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using UCSImporter.Application.Handlers;
using UCSImporter.CompositionRoot.Configurations;
using UCSImporter.Data;
using UCSImporter.Data.Apis;
using UCSImporter.Data.Apis.Contracts;
using UCSImporter.Data.Persistence;
using UCSImporter.Domain.Contracts;

namespace UCSImporter.CompositionRoot;

public static class RegistrationExtensions
{
    public static IServiceCollection AddUCSImporterCore(this IServiceCollection builder)
    {
        return builder.AddMediatR(typeof(ImportChartsHandler).Assembly);
    }

    public static IServiceCollection AddUCSImporterInfrastructure(this IServiceCollection builder,
        CosmosConfiguration cosmosConfig)
    {
        builder.AddTransient<IExistingChartRepository, CosmosExistingChartsRepository>()
            .AddSingleton<IMessageClient, InMemoryMessageClient>()
            .AddTransient<IPiuGameSiteApi, PiuGameSiteApi>()
            .AddTransient<INewChartRepository, AndamiroNewChartRepository>()
            .AddDbContext<ChartDbContext>(o =>
            {
                if (!cosmosConfig.IsConfigured)
                    o.UseInMemoryDatabase("Cosmos");
                else
                    o.UseCosmos(cosmosConfig.AccountEndpoint, cosmosConfig.AccountKey, cosmosConfig.DatabaseName);
            })
            .AddHttpClient<IPiuGameSiteApi, PiuGameSiteApi>(o =>
            {
                o.BaseAddress = new Uri("https://www.piugame.com");
            });

        return builder;
    }
}