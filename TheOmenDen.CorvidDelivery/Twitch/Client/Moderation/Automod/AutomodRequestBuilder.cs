// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
using TheOmenDen.CorvidDelivery.Twitch.Moderation.Automod.Message;
using TheOmenDen.CorvidDelivery.Twitch.Moderation.Automod.Settings;
namespace TheOmenDen.CorvidDelivery.Twitch.Moderation.Automod {
    /// <summary>
    /// Builds and executes requests for operations under \moderation\automod
    /// </summary>
    public class AutomodRequestBuilder : BaseRequestBuilder {
        /// <summary>The message property</summary>
        public MessageRequestBuilder Message { get =>
            new MessageRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The settings property</summary>
        public SettingsRequestBuilder Settings { get =>
            new SettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="AutomodRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AutomodRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/moderation/automod", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="AutomodRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AutomodRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/moderation/automod", rawUrl) {
        }
    }
}
