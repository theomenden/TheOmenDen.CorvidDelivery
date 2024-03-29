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
namespace TheOmenDen.CorvidDelivery.TiltifyApi.Oauth.Token {
    /// <summary>
    /// Builds and executes requests for operations under \oauth\token
    /// </summary>
    public class TokenRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new <see cref="TokenRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TokenRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/oauth/token?client_id={client_id}&client_secret={client_secret}&grant_type={grant_type}{&code*,refresh_token*,scope*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="TokenRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TokenRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/oauth/token?client_id={client_id}&client_secret={client_secret}&grant_type={grant_type}{&code*,refresh_token*,scope*}", rawUrl) {
        }
        /// <summary>
        /// Returns an access and refresh token with a provided client id, secret, and grant type. Tokens expire in `7200` seconds.
        /// </summary>
        /// <returns>A <see cref="Stream"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Unauthorized">When receiving a 401 status code</exception>
        /// <exception cref="NotFound">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> PostAsync(Action<RequestConfiguration<TokenRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Stream> PostAsync(Action<RequestConfiguration<TokenRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToPostRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"401", Unauthorized.CreateFromDiscriminatorValue},
                {"404", NotFound.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns an access and refresh token with a provided client id, secret, and grant type. Tokens expire in `7200` seconds.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<TokenRequestBuilderPostQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<TokenRequestBuilderPostQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="TokenRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public TokenRequestBuilder WithUrl(string rawUrl) {
            return new TokenRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns an access and refresh token with a provided client id, secret, and grant type. Tokens expire in `7200` seconds.
        /// </summary>
        public class TokenRequestBuilderPostQueryParameters {
            /// <summary>Client Id</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("client_id")]
            public string? ClientId { get; set; }
#nullable restore
#else
            [QueryParameter("client_id")]
            public string ClientId { get; set; }
#endif
            /// <summary>Client Secret</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("client_secret")]
            public string? ClientSecret { get; set; }
#nullable restore
#else
            [QueryParameter("client_secret")]
            public string ClientSecret { get; set; }
#endif
            /// <summary>Authorization Code; `*required` if using `authorization_code` grant type</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("code")]
            public string? Code { get; set; }
#nullable restore
#else
            [QueryParameter("code")]
            public string Code { get; set; }
#endif
            /// <summary>Grant Type</summary>
            [Obsolete("This property is deprecated, use GrantTypeAsPostGrantTypeQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("grant_type")]
            public string? GrantType { get; set; }
#nullable restore
#else
            [QueryParameter("grant_type")]
            public string GrantType { get; set; }
#endif
            /// <summary>Grant Type</summary>
            [QueryParameter("grant_type")]
            public PostGrant_typeQueryParameterType? GrantTypeAsPostGrantTypeQueryParameterType { get; set; }
            /// <summary>Refresh Token; `*required` if using `refresh_token` grant type</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("refresh_token")]
            public string? RefreshToken { get; set; }
#nullable restore
#else
            [QueryParameter("refresh_token")]
            public string RefreshToken { get; set; }
#endif
            /// <summary>Scope</summary>
            [Obsolete("This property is deprecated, use ScopeAsPostScopeQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("scope")]
            public string? Scope { get; set; }
#nullable restore
#else
            [QueryParameter("scope")]
            public string Scope { get; set; }
#endif
            /// <summary>Scope</summary>
            [QueryParameter("scope")]
            public PostScopeQueryParameterType? ScopeAsPostScopeQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class TokenRequestBuilderPostRequestConfiguration : RequestConfiguration<TokenRequestBuilderPostQueryParameters> {
        }
    }
}
