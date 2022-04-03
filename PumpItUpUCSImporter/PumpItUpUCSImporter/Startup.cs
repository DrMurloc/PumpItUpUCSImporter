using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using UCSImporter.AzureFunction;
using UCSImporter.CompositionRoot;

[assembly: FunctionsStartup(typeof(Startup))]

namespace UCSImporter.AzureFunction;

public sealed class Startup : FunctionsStartup
{
    public override void ConfigureAppConfiguration(IFunctionsConfigurationBuilder builder)
    {
        builder.ConfigurationBuilder
            .AddEnvironmentVariables();
    }

    public override void Configure(IFunctionsHostBuilder builder)
    {
        builder.Services
            .AddUCSImporterCore();
    }
}