// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace TheOmenDen.CorvidDelivery.Twitch.Moderation.Chat {
    /// <summary>
    /// Builds and executes requests for operations under \moderation\chat
    /// </summary>
    public class ChatRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new <see cref="ChatRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ChatRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/moderation/chat{?broadcaster_id*,message_id*,moderator_id*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="ChatRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ChatRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/moderation/chat{?broadcaster_id*,message_id*,moderator_id*}", rawUrl) {
        }
        /// <summary>
        /// Removes a single chat message or all chat messages from the broadcaster’s chat room.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<ChatRequestBuilderDeleteQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<ChatRequestBuilderDeleteQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Removes a single chat message or all chat messages from the broadcaster’s chat room.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<ChatRequestBuilderDeleteQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<ChatRequestBuilderDeleteQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="ChatRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ChatRequestBuilder WithUrl(string rawUrl) {
            return new ChatRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Removes a single chat message or all chat messages from the broadcaster’s chat room.
        /// </summary>
        public class ChatRequestBuilderDeleteQueryParameters {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("broadcaster_id")]
            public string? BroadcasterId { get; set; }
#nullable restore
#else
            [QueryParameter("broadcaster_id")]
            public string BroadcasterId { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("message_id")]
            public string? MessageId { get; set; }
#nullable restore
#else
            [QueryParameter("message_id")]
            public string MessageId { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("moderator_id")]
            public string? ModeratorId { get; set; }
#nullable restore
#else
            [QueryParameter("moderator_id")]
            public string ModeratorId { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ChatRequestBuilderDeleteRequestConfiguration : RequestConfiguration<ChatRequestBuilderDeleteQueryParameters> {
        }
    }
}
