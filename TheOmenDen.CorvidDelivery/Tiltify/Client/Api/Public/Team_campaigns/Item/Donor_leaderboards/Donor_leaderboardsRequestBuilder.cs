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
namespace TheOmenDen.CorvidDelivery.TiltifyApi.Api.Public.Team_campaigns.Item.Donor_leaderboards {
    /// <summary>
    /// Builds and executes requests for operations under \api\public\team_campaigns\{team_campaign_id}\donor_leaderboards
    /// </summary>
    public class Donor_leaderboardsRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new <see cref="Donor_leaderboardsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Donor_leaderboardsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/public/team_campaigns/{team_campaign_id}/donor_leaderboards{?after*,before*,limit*,time_type*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="Donor_leaderboardsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Donor_leaderboardsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/public/team_campaigns/{team_campaign_id}/donor_leaderboards{?after*,before*,limit*,time_type*}", rawUrl) {
        }
        /// <summary>
        /// List top donors
        /// </summary>
        /// <returns>A <see cref="Donor_leaderboardsGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Unauthorized">When receiving a 401 status code</exception>
        /// <exception cref="NotFound">When receiving a 404 status code</exception>
        /// <exception cref="UnprocessableEntity">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Donor_leaderboardsGetResponse?> GetAsDonor_leaderboardsGetResponseAsync(Action<RequestConfiguration<Donor_leaderboardsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Donor_leaderboardsGetResponse> GetAsDonor_leaderboardsGetResponseAsync(Action<RequestConfiguration<Donor_leaderboardsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"401", Unauthorized.CreateFromDiscriminatorValue},
                {"404", NotFound.CreateFromDiscriminatorValue},
                {"422", UnprocessableEntity.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Donor_leaderboardsGetResponse>(requestInfo, Donor_leaderboardsGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List top donors
        /// </summary>
        /// <returns>A <see cref="Donor_leaderboardsResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Unauthorized">When receiving a 401 status code</exception>
        /// <exception cref="NotFound">When receiving a 404 status code</exception>
        /// <exception cref="UnprocessableEntity">When receiving a 422 status code</exception>
        [Obsolete("This method is obsolete. Use GetAsDonor_leaderboardsGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Donor_leaderboardsResponse?> GetAsync(Action<RequestConfiguration<Donor_leaderboardsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Donor_leaderboardsResponse> GetAsync(Action<RequestConfiguration<Donor_leaderboardsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"401", Unauthorized.CreateFromDiscriminatorValue},
                {"404", NotFound.CreateFromDiscriminatorValue},
                {"422", UnprocessableEntity.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Donor_leaderboardsResponse>(requestInfo, Donor_leaderboardsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List top donors
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Donor_leaderboardsRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Donor_leaderboardsRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="Donor_leaderboardsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Donor_leaderboardsRequestBuilder WithUrl(string rawUrl) {
            return new Donor_leaderboardsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// List top donors
        /// </summary>
        public class Donor_leaderboardsRequestBuilderGetQueryParameters {
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
            /// <summary>The time range to use in leaderboard generation</summary>
            [Obsolete("This property is deprecated, use TimeTypeAsGetTimeTypeQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("time_type")]
            public string? TimeType { get; set; }
#nullable restore
#else
            [QueryParameter("time_type")]
            public string TimeType { get; set; }
#endif
            /// <summary>The time range to use in leaderboard generation</summary>
            [QueryParameter("time_type")]
            public GetTime_typeQueryParameterType? TimeTypeAsGetTimeTypeQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class Donor_leaderboardsRequestBuilderGetRequestConfiguration : RequestConfiguration<Donor_leaderboardsRequestBuilderGetQueryParameters> {
        }
    }
}
