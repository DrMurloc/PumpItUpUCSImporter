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
        var piuConfig = config.GetSection("PiuGame")?.Get<PiuGameConfiguration>() ?? new PiuGameConfiguration();
        var serviceBusConfig = config.GetSection("ServiceBus")?.Get<ServiceBusConfiguration>() ??
                               new ServiceBusConfiguration();
        builder.Services
            .AddUCSImporterCore()
            .AddUCSImporterInfrastructure(cosmosConfig, serviceBusConfig,
                piuConfig);
    }
}