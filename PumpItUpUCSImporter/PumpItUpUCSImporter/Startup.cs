using System;
using System.Linq;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UCSImporter.AzureFunction;
using UCSImporter.CompositionRoot;
using UCSImporter.CompositionRoot.Configurations;
using UCSImporter.Data.Configuration;

[assembly: FunctionsStartup(typeof(Startup))]

namespace UCSImporter.AzureFunction;

public sealed class Startup : FunctionsStartup
{
    public override void ConfigureAppConfiguration(IFunctionsConfigurationBuilder builder)
    {
        builder.ConfigurationBuilder
            .AddEnvironmentVariables()
            .AddUserSecrets<Startup>();
    }

    public override void Configure(IFunctionsHostBuilder builder)
    {
        var config = builder.Services.BuildServiceProvider().GetRequiredService<IConfiguration>();
        var cosmosConfig = config.GetSection("Cosmos")?.Get<CosmosConfiguration>() ?? new CosmosConfiguration();
        var discordSection = config.GetSection("Discord");
        var piuConfig = config.GetSection("PiuGame")?.Get<PiuGameConfiguration>() ?? new PiuGameConfiguration();
        var discordConfig = new DiscordConfiguration
        {
            BotToken = discordSection?["BotToken"] ?? string.Empty,
            ChannelIds =
                discordSection?["ChannelIds"]?.Split(",")
                    .Select(id => ulong.TryParse(id, out var value) ? value : default).Where(id => id != default)
                    .ToArray() ?? Array.Empty<ulong>()
        };
        builder.Services
            .AddUCSImporterCore()
            .AddUCSImporterInfrastructure(cosmosConfig, config.GetValue<bool>("UseInMemoryNewCharts"), discordConfig,
                piuConfig);
    }
}