// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
using TheOmenDen.CorvidDelivery.TiltifyApi.Api.Public.Users.By.Slug.Item;
namespace TheOmenDen.CorvidDelivery.TiltifyApi.Api.Public.Users.By.Slug {
    /// <summary>
    /// Builds and executes requests for operations under \api\public\users\by\slug
    /// </summary>
    public class SlugRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the TheOmenDen.CorvidDelivery.TiltifyApi.api.public.users.by.slug.item collection</summary>
        /// <param name="position">User slug</param>
        /// <returns>A <see cref="WithSlugItemRequestBuilder"/></returns>
        public WithSlugItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("slug", position);
            return new WithSlugItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new <see cref="SlugRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SlugRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/public/users/by/slug", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="SlugRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SlugRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/public/users/by/slug", rawUrl) {
        }
    }
}
