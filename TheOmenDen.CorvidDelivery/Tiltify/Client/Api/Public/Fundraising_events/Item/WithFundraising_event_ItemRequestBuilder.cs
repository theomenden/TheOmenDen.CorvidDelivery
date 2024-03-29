// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
using TheOmenDen.CorvidDelivery.TiltifyApi.Api.Public.Fundraising_events.Item.Configured_leaderboard;
using TheOmenDen.CorvidDelivery.TiltifyApi.Api.Public.Fundraising_events.Item.Donations;
using TheOmenDen.CorvidDelivery.TiltifyApi.Api.Public.Fundraising_events.Item.Donor_leaderboard;
using TheOmenDen.CorvidDelivery.TiltifyApi.Api.Public.Fundraising_events.Item.Fitness_goals;
using TheOmenDen.CorvidDelivery.TiltifyApi.Api.Public.Fundraising_events.Item.Supporting_events;
using TheOmenDen.CorvidDelivery.TiltifyApi.Api.Public.Fundraising_events.Item.Team_fitness_distance_leaderboard;
using TheOmenDen.CorvidDelivery.TiltifyApi.Api.Public.Fundraising_events.Item.Team_fitness_time_leaderboard;
using TheOmenDen.CorvidDelivery.TiltifyApi.Api.Public.Fundraising_events.Item.Team_leaderboard;
using TheOmenDen.CorvidDelivery.TiltifyApi.Api.Public.Fundraising_events.Item.User_fitness_distance_leaderboard;
using TheOmenDen.CorvidDelivery.TiltifyApi.Api.Public.Fundraising_events.Item.User_fitness_time_leaderboard;
using TheOmenDen.CorvidDelivery.TiltifyApi.Api.Public.Fundraising_events.Item.User_leaderboard;
using TheOmenDen.CorvidDelivery.TiltifyApi.Models;
namespace TheOmenDen.CorvidDelivery.TiltifyApi.Api.Public.Fundraising_events.Item {
    /// <summary>
    /// Builds and executes requests for operations under \api\public\fundraising_events\{fundraising_event_id}
    /// </summary>
    public class WithFundraising_event_ItemRequestBuilder : BaseRequestBuilder {
        /// <summary>The configured_leaderboard property</summary>
        public Configured_leaderboardRequestBuilder Configured_leaderboard { get =>
            new Configured_leaderboardRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The donations property</summary>
        public DonationsRequestBuilder Donations { get =>
            new DonationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The donor_leaderboard property</summary>
        public Donor_leaderboardRequestBuilder Donor_leaderboard { get =>
            new Donor_leaderboardRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The fitness_goals property</summary>
        public Fitness_goalsRequestBuilder Fitness_goals { get =>
            new Fitness_goalsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The supporting_events property</summary>
        public Supporting_eventsRequestBuilder Supporting_events { get =>
            new Supporting_eventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The team_fitness_distance_leaderboard property</summary>
        public Team_fitness_distance_leaderboardRequestBuilder Team_fitness_distance_leaderboard { get =>
            new Team_fitness_distance_leaderboardRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The team_fitness_time_leaderboard property</summary>
        public Team_fitness_time_leaderboardRequestBuilder Team_fitness_time_leaderboard { get =>
            new Team_fitness_time_leaderboardRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The team_leaderboard property</summary>
        public Team_leaderboardRequestBuilder Team_leaderboard { get =>
            new Team_leaderboardRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The user_fitness_distance_leaderboard property</summary>
        public User_fitness_distance_leaderboardRequestBuilder User_fitness_distance_leaderboard { get =>
            new User_fitness_distance_leaderboardRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The user_fitness_time_leaderboard property</summary>
        public User_fitness_time_leaderboardRequestBuilder User_fitness_time_leaderboard { get =>
            new User_fitness_time_leaderboardRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The user_leaderboard property</summary>
        public User_leaderboardRequestBuilder User_leaderboard { get =>
            new User_leaderboardRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="WithFundraising_event_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithFundraising_event_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/public/fundraising_events/{fundraising_event_id}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="WithFundraising_event_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithFundraising_event_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/public/fundraising_events/{fundraising_event_id}", rawUrl) {
        }
        /// <summary>
        /// Returns a fundraising event by its ID
        /// </summary>
        /// <returns>A <see cref="WithFundraising_event_GetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Unauthorized">When receiving a 401 status code</exception>
        /// <exception cref="NotFound">When receiving a 404 status code</exception>
        /// <exception cref="UnprocessableEntity">When receiving a 422 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<WithFundraising_event_GetResponse?> GetAsWithFundraising_event_GetResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<WithFundraising_event_GetResponse> GetAsWithFundraising_event_GetResponseAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"401", Unauthorized.CreateFromDiscriminatorValue},
                {"404", NotFound.CreateFromDiscriminatorValue},
                {"422", UnprocessableEntity.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<WithFundraising_event_GetResponse>(requestInfo, WithFundraising_event_GetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns a fundraising event by its ID
        /// </summary>
        /// <returns>A <see cref="WithFundraising_event_Response"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Unauthorized">When receiving a 401 status code</exception>
        /// <exception cref="NotFound">When receiving a 404 status code</exception>
        /// <exception cref="UnprocessableEntity">When receiving a 422 status code</exception>
        [Obsolete("This method is obsolete. Use GetAsWithFundraising_event_GetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<WithFundraising_event_Response?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<WithFundraising_event_Response> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"401", Unauthorized.CreateFromDiscriminatorValue},
                {"404", NotFound.CreateFromDiscriminatorValue},
                {"422", UnprocessableEntity.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<WithFundraising_event_Response>(requestInfo, WithFundraising_event_Response.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns a fundraising event by its ID
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="WithFundraising_event_ItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public WithFundraising_event_ItemRequestBuilder WithUrl(string rawUrl) {
            return new WithFundraising_event_ItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class WithFundraising_event_ItemRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
    }
}
