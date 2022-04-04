using System.Collections.Immutable;
using Discord;
using Discord.WebSocket;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using UCSImporter.Data.Configuration;
using UCSImporter.Domain.Contracts;
using UCSImporter.Domain.ValueTypes;

namespace UCSImporter.Data;

public sealed class DiscordMessageClient : IMessageClient
{
    private readonly DiscordConfiguration _config;
    private readonly ILogger _logger;

    public DiscordMessageClient(ILogger<DiscordMessageClient> logger,
        IOptions<DiscordConfiguration> discordConfiguration)
    {
        _logger = logger;
        _config = discordConfiguration.Value;
    }

    public async Task SendMessages(IEnumerable<Message> messages, CancellationToken cancellationToken = default)
    {
        var client = new DiscordSocketClient(new DiscordSocketConfig
        {
            LogLevel = LogSeverity.Verbose
        });
        client.Log += msg =>
        {
            _logger.LogInformation(msg.Message);
            return Task.CompletedTask;
        };
        await client.LoginAsync(TokenType.Bot, _config.BotToken);
        await client.StartAsync();
        var messageArray = messages.ToImmutableArray();
        foreach (var channelId in _config.ChannelIds)
        {
            var channel = await client.GetChannelAsync(channelId) as IMessageChannel;
            if (channel == null)
            {
                _logger.LogWarning($"Channel {channel} was not reachable");
                continue;
            }

            foreach (var message in messageArray)
                await channel.SendMessageAsync(message);
        }

        await client.StopAsync();
    }
}