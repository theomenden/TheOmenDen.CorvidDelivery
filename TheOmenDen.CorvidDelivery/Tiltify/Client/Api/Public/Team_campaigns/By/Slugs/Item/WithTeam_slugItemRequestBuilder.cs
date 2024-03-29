// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
using TheOmenDen.CorvidDelivery.TiltifyApi.Api.Public.Team_campaigns.By.Slugs.Item.Item;
namespace TheOmenDen.CorvidDelivery.TiltifyApi.Api.Public.Team_campaigns.By.Slugs.Item {
    /// <summary>
    /// Builds and executes requests for operations under \api\public\team_campaigns\by\slugs\{team_slug}
    /// </summary>
    public class WithTeam_slugItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the TheOmenDen.CorvidDelivery.TiltifyApi.api.public.team_campaigns.by.slugs.item.item collection</summary>
        /// <param name="position">Campaign Slug</param>
        /// <returns>A <see cref="WithTeam_campaign_slugItemRequestBuilder"/></returns>
        public WithTeam_campaign_slugItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("team_campaign_slug", position);
            return new WithTeam_campaign_slugItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new <see cref="WithTeam_slugItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithTeam_slugItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/public/team_campaigns/by/slugs/{team_slug}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="WithTeam_slugItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithTeam_slugItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/public/team_campaigns/by/slugs/{team_slug}", rawUrl) {
        }
    }
}
