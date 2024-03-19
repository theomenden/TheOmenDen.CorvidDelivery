// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
using TheOmenDen.CorvidDelivery.TiltifyApi.Models;
namespace TheOmenDen.CorvidDelivery.TiltifyApi.Api.Private.Webhook_enpdoints.Item.Webhook_subscriptions.Item {
    /// <summary>
    /// Builds and executes requests for operations under \api\private\webhook_enpdoints\{webhook_endpoint_id}\webhook_subscriptions\{event_id}
    /// </summary>
    public class WithEvent_ItemRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new <see cref="WithEvent_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithEvent_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/private/webhook_enpdoints/{webhook_endpoint_id}/webhook_subscriptions/{event_id}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="WithEvent_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithEvent_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/private/webhook_enpdoints/{webhook_endpoint_id}/webhook_subscriptions/{event_id}", rawUrl) {
        }
        /// <summary>
        /// Use [putWebhookSubscription](#tag/webhook/operation/putWebhookSubscription) instead. This operation was deprecated due to a spelling error.
        /// </summary>
        /// <returns>A <see cref="WebhookSubscription"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Unauthorized">When receiving a 401 status code</exception>
        /// <exception cref="NotFound">When receiving a 404 status code</exception>
        /// <exception cref="UnprocessableEntity">When receiving a 422 status code</exception>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<WebhookSubscription?> PutAsync(WithEvent_PutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<WebhookSubscription> PutAsync(WithEvent_PutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"401", Unauthorized.CreateFromDiscriminatorValue},
                {"404", NotFound.CreateFromDiscriminatorValue},
                {"422", UnprocessableEntity.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<WebhookSubscription>(requestInfo, WebhookSubscription.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Use [putWebhookSubscription](#tag/webhook/operation/putWebhookSubscription) instead. This operation was deprecated due to a spelling error.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(WithEvent_PutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(WithEvent_PutRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="WithEvent_ItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        [Obsolete("")]
        public WithEvent_ItemRequestBuilder WithUrl(string rawUrl) {
            return new WithEvent_ItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class WithEvent_ItemRequestBuilderPutRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
    }
}
