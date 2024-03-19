// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
using TheOmenDen.CorvidDelivery.TiltifyApi.Api.Public.Teams.By;
using TheOmenDen.CorvidDelivery.TiltifyApi.Api.Public.Teams.Item;
namespace TheOmenDen.CorvidDelivery.TiltifyApi.Api.Public.Teams {
    /// <summary>
    /// Builds and executes requests for operations under \api\public\teams
    /// </summary>
    public class TeamsRequestBuilder : BaseRequestBuilder {
        /// <summary>The by property</summary>
        public ByRequestBuilder By { get =>
            new ByRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the TheOmenDen.CorvidDelivery.TiltifyApi.api.public.teams.item collection</summary>
        /// <param name="position">Team ID</param>
        /// <returns>A <see cref="WithTeam_ItemRequestBuilder"/></returns>
        public WithTeam_ItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("team_id", position);
            return new WithTeam_ItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new <see cref="TeamsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TeamsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/public/teams", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="TeamsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TeamsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/public/teams", rawUrl) {
        }
    }
}
