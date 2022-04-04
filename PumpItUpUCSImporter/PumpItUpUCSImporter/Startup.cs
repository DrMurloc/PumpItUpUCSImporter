using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UCSImporter.AzureFunction;
using UCSImporter.CompositionRoot;
using UCSImporter.CompositionRoot.Configurations;

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
        var cosmosConfig = config?.GetSection("Cosmos")?.Get<CosmosConfiguration>() ?? new CosmosConfiguration();
        builder.Services
            .AddUCSImporterCore()
            .AddUCSImporterInfrastructure(cosmosConfig);
    }
}