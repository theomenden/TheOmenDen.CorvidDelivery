// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
using TheOmenDen.CorvidDelivery.TiltifyApi.Api.Public.Campaigns.By;
using TheOmenDen.CorvidDelivery.TiltifyApi.Api.Public.Campaigns.Item;
namespace TheOmenDen.CorvidDelivery.TiltifyApi.Api.Public.Campaigns {
    /// <summary>
    /// Builds and executes requests for operations under \api\public\campaigns
    /// </summary>
    public class CampaignsRequestBuilder : BaseRequestBuilder {
        /// <summary>The by property</summary>
        public ByRequestBuilder By { get =>
            new ByRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the TheOmenDen.CorvidDelivery.TiltifyApi.api.public.campaigns.item collection</summary>
        /// <param name="position">Campaign ID</param>
        /// <returns>A <see cref="WithCampaign_ItemRequestBuilder"/></returns>
        public WithCampaign_ItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("campaign_id", position);
            return new WithCampaign_ItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new <see cref="CampaignsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CampaignsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/public/campaigns", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="CampaignsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CampaignsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/public/campaigns", rawUrl) {
        }
    }
}
