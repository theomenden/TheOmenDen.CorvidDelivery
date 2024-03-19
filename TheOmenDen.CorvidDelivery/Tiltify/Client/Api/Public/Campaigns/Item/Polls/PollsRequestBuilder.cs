// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
using TheOmenDen.CorvidDelivery.TiltifyApi.Api.Public.Campaigns.Item.Polls.Item;
using TheOmenDen.CorvidDelivery.TiltifyApi.Models;
namespace TheOmenDen.CorvidDelivery.TiltifyApi.Api.Public.Campaigns.Item.Polls {
    /// <summary>
    /// Builds and executes requests for operations under \api\public\campaigns\{campaign_id}\polls
    /// </summary>
    public class PollsRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the TheOmenDen.CorvidDelivery.TiltifyApi.api.public.campaigns.item.polls.item collection</summary>
        /// <param name="position">Poll ID</param>
        /// <returns>A <see cref="WithPoll_ItemRequestBuilder"/></returns>
        public WithPoll_ItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("poll_id", position);
            return new WithPoll_ItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new <see cref="PollsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PollsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/public/campaigns/{campaign_id}/polls{?after*,before*,limit*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="PollsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PollsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/public/campaigns/{campaign_id}/polls{?after*,before*,limit*}", rawUrl) {
        }
        /// <summary>
        /// List polls
        /// </summary>
        /// <returns>A <see cref="PollsGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Unauthorized">When receiving a 401 status code</exception>
        /// <exception cref="NotFound">When receiving a 404 status code</exception>
        /// <exception cref="UnprocessableEntity">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<PollsGetResponse?> GetAsPollsGetResponseAsync(Action<RequestConfiguration<PollsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<PollsGetResponse> GetAsPollsGetResponseAsync(Action<RequestConfiguration<PollsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"401", Unauthorized.CreateFromDiscriminatorValue},
                {"404", NotFound.CreateFromDiscriminatorValue},
                {"422", UnprocessableEntity.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<PollsGetResponse>(requestInfo, PollsGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List polls
        /// </summary>
        /// <returns>A <see cref="PollsResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Unauthorized">When receiving a 401 status code</exception>
        /// <exception cref="NotFound">When receiving a 404 status code</exception>
        /// <exception cref="UnprocessableEntity">When receiving a 422 status code</exception>
        [Obsolete("This method is obsolete. Use GetAsPollsGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<PollsResponse?> GetAsync(Action<RequestConfiguration<PollsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<PollsResponse> GetAsync(Action<RequestConfiguration<PollsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"401", Unauthorized.CreateFromDiscriminatorValue},
                {"404", NotFound.CreateFromDiscriminatorValue},
                {"422", UnprocessableEntity.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<PollsResponse>(requestInfo, PollsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List polls
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<PollsRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<PollsRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="PollsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public PollsRequestBuilder WithUrl(string rawUrl) {
            return new PollsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// List polls
        /// </summary>
        public class PollsRequestBuilderGetQueryParameters {
            /// <summary>Returns records after the given cursor</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("after")]
            public string? After { get; set; }
#nullable restore
#else
            [QueryParameter("after")]
            public string After { get; set; }
#endif
            /// <summary>Returns records before the given cursor</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("before")]
            public string? Before { get; set; }
#nullable restore
#else
            [QueryParameter("before")]
            public string Before { get; set; }
#endif
            [QueryParameter("limit")]
            public int? Limit { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class PollsRequestBuilderGetRequestConfiguration : RequestConfiguration<PollsRequestBuilderGetQueryParameters> {
        }
    }
}
