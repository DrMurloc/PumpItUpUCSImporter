namespace UCSImporter.CompositionRoot.Configurations;

public sealed class CosmosConfiguration
{
    public string AccountEndpoint { get; set; }
    public string AccountKey { get; set; }
    public string DatabaseName { get; set; }

    public bool IsConfigured => !string.IsNullOrWhiteSpace(AccountEndpoint) && !string.IsNullOrWhiteSpace(AccountKey) &&
                                !string.IsNullOrWhiteSpace(DatabaseName);
}