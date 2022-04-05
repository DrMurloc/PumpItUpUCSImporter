﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using UCSImporter.Application.Handlers;
using UCSImporter.CompositionRoot.Configurations;
using UCSImporter.Data;
using UCSImporter.Data.Apis;
using UCSImporter.Data.Apis.Contracts;
using UCSImporter.Data.Configuration;
using UCSImporter.Data.InMemory;
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
        CosmosConfiguration cosmosConfig, bool useInMemoryNewCharts, DiscordConfiguration discordConfiguration,
        PiuGameConfiguration piuConfiguration)
    {
        if (discordConfiguration.IsConfigured)
            builder.AddTransient<IMessageClient, DiscordMessageClient>()
                .Configure<DiscordConfiguration>(o =>
                {
                    o.ChannelIds = discordConfiguration.ChannelIds;
                    o.BotToken = discordConfiguration.BotToken;
                });
        else
            builder.AddTransient<IMessageClient, LoggingMessageClient>();


        if (piuConfiguration.IsConfigured)
        {
            builder.AddHttpClient<IPiuGameSiteApi, PiuGameSiteApi>(o => { });
            builder
                .AddTransient<IChartStepInfoRepository, AndamiroChartStepInfoRepository>()
                .AddTransient<INewChartRepository, AndamiroNewChartRepository>()
                .AddSingleton<IPiuGameSiteApi, PiuGameSiteApi>()
                .Configure<PiuGameConfiguration>(o =>
                {
                    o.Email = piuConfiguration.Email;
                    o.Password = piuConfiguration.Password;
                });
        }
        else
        {
            builder.AddTransient<INewChartRepository, InMemoryNewChartRepository>();
        }

        builder.AddTransient<IExistingChartRepository, CosmosExistingChartsRepository>()
            .AddTransient<IMessageClient, DiscordMessageClient>()
            .AddTransient<IChartStepInfoRepository, AndamiroChartStepInfoRepository>()
            .AddDbContext<ChartDbContext>(o =>
            {
                if (!cosmosConfig.IsConfigured)
                    o.UseInMemoryDatabase("Cosmos");
                else
                    o.UseCosmos(cosmosConfig.AccountEndpoint, cosmosConfig.AccountKey, cosmosConfig.DatabaseName);
            });

        return builder;
    }
}