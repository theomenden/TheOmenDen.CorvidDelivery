// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
using TheOmenDen.CorvidDelivery.Twitch.Tags.Streams;
namespace TheOmenDen.CorvidDelivery.Twitch.Tags {
    /// <summary>
    /// Builds and executes requests for operations under \tags
    /// </summary>
    public class TagsRequestBuilder : BaseRequestBuilder {
        /// <summary>The streams property</summary>
        public StreamsRequestBuilder Streams { get =>
            new StreamsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="TagsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TagsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/tags", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="TagsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TagsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/tags", rawUrl) {
        }
    }
}
