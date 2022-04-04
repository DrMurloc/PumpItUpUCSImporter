namespace UCSImporter.Data.Configuration;

public sealed class DiscordConfiguration
{
    public string BotToken { get; set; }
    public IEnumerable<ulong> ChannelIds { get; set; }
    public bool IsConfigured => !string.IsNullOrWhiteSpace(BotToken) && (ChannelIds?.Any() ?? false);
}