using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;
using TwitchLib.EventSub.Webhooks.Core;
using TwitchLib.EventSub.Webhooks.Core.EventArgs;
using TwitchLib.EventSub.Webhooks.Core.EventArgs.Channel;

namespace TheOmenDen.CorvidDelivery.Twitch
{
    internal sealed class EventSubHostedService : IHostedService
    {
        private readonly ILogger<EventSubHostedService> _logger;
        private readonly IEventSubWebhooks _eventSubWebhooks;

        public EventSubHostedService(ILogger<EventSubHostedService> logger, IEventSubWebhooks eventSubWebhooks)
        {
            _logger = logger;
            _eventSubWebhooks = eventSubWebhooks;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Starting EventSub Webhooks");
            _eventSubWebhooks.OnError += OnError;
            _eventSubWebhooks.OnChannelFollow += OnChannelFollow;
            return Task.CompletedTask;
        }


        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Stopping EventSub Webhooks");
            _eventSubWebhooks.OnError -= OnError;
            _eventSubWebhooks.OnChannelFollow -= OnChannelFollow;
            return Task.CompletedTask;
        }

        private void OnError(object sender, OnErrorArgs e)
        {
            _logger.LogError("Error in EventSub Webhooks: Reason: {Reason} - Message: {Message}", e.Reason, e.Message);
        }

        private void OnChannelFollow(object sender, ChannelFollowArgs e)
        {
            _logger.LogInformation("Channel Follow Event: User: {User} - Followed At: {FollowedAt}", e.User, e.FollowedAt);
        }
    }
}
