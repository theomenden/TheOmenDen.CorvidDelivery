// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
using TheOmenDen.CorvidDelivery.TiltifyApi.Api.Public.LegacyRelays.Item.Item;
namespace TheOmenDen.CorvidDelivery.TiltifyApi.Api.Public.LegacyRelays.Item {
    /// <summary>
    /// Builds and executes requests for operations under \api\public\legacy-relays\{provider}
    /// </summary>
    public class WithProviderItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the TheOmenDen.CorvidDelivery.TiltifyApi.api.public.legacyRelays.item.item collection</summary>
        /// <param name="position">The providers UUID</param>
        /// <returns>A <see cref="WithUuItemRequestBuilder"/></returns>
        [Obsolete("")]
        public WithUuItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("uuid", position);
            return new WithUuItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new <see cref="WithProviderItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithProviderItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/public/legacy-relays/{provider}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="WithProviderItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithProviderItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/public/legacy-relays/{provider}", rawUrl) {
        }
    }
}
