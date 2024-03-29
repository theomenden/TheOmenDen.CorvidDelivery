// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
using TheOmenDen.CorvidDelivery.Twitch.Chat.Announcements;
using TheOmenDen.CorvidDelivery.Twitch.Chat.Badges;
using TheOmenDen.CorvidDelivery.Twitch.Chat.Chatters;
using TheOmenDen.CorvidDelivery.Twitch.Chat.Color;
using TheOmenDen.CorvidDelivery.Twitch.Chat.Emotes;
using TheOmenDen.CorvidDelivery.Twitch.Chat.Messages;
using TheOmenDen.CorvidDelivery.Twitch.Chat.Settings;
using TheOmenDen.CorvidDelivery.Twitch.Chat.Shoutouts;
namespace TheOmenDen.CorvidDelivery.Twitch.Chat {
    /// <summary>
    /// Builds and executes requests for operations under \chat
    /// </summary>
    public class ChatRequestBuilder : BaseRequestBuilder {
        /// <summary>The announcements property</summary>
        public AnnouncementsRequestBuilder Announcements { get =>
            new AnnouncementsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The badges property</summary>
        public BadgesRequestBuilder Badges { get =>
            new BadgesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The chatters property</summary>
        public ChattersRequestBuilder Chatters { get =>
            new ChattersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The color property</summary>
        public ColorRequestBuilder Color { get =>
            new ColorRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The emotes property</summary>
        public EmotesRequestBuilder Emotes { get =>
            new EmotesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The messages property</summary>
        public MessagesRequestBuilder Messages { get =>
            new MessagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The settings property</summary>
        public SettingsRequestBuilder Settings { get =>
            new SettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The shoutouts property</summary>
        public ShoutoutsRequestBuilder Shoutouts { get =>
            new ShoutoutsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="ChatRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ChatRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/chat", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="ChatRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ChatRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/chat", rawUrl) {
        }
    }
}
