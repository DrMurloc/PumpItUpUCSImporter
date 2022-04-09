namespace UCSImporter.Data.Configuration;

public sealed class ServiceBusConfiguration
{
    public string ConnectionString { get; set; }
    public string QueueName { get; set; }
    public bool IsConfigured => !string.IsNullOrWhiteSpace(ConnectionString);
}