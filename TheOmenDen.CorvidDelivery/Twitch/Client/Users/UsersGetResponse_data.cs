// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace TheOmenDen.CorvidDelivery.Twitch.Users {
    public class UsersGetResponse_data : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The broadcaster_type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BroadcasterType { get; set; }
#nullable restore
#else
        public string BroadcasterType { get; set; }
#endif
        /// <summary>The created_at property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedAt { get; set; }
#nullable restore
#else
        public string CreatedAt { get; set; }
#endif
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The display_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The email property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email { get; set; }
#nullable restore
#else
        public string Email { get; set; }
#endif
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The login property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Login { get; set; }
#nullable restore
#else
        public string Login { get; set; }
#endif
        /// <summary>The offline_image_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OfflineImageUrl { get; set; }
#nullable restore
#else
        public string OfflineImageUrl { get; set; }
#endif
        /// <summary>The profile_image_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProfileImageUrl { get; set; }
#nullable restore
#else
        public string ProfileImageUrl { get; set; }
#endif
        /// <summary>The type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>The view_count property</summary>
        public double? ViewCount { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="UsersGetResponse_data"/> and sets the default values.
        /// </summary>
        public UsersGetResponse_data() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="UsersGetResponse_data"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UsersGetResponse_data CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UsersGetResponse_data();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"broadcaster_type", n => { BroadcasterType = n.GetStringValue(); } },
                {"created_at", n => { CreatedAt = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"display_name", n => { DisplayName = n.GetStringValue(); } },
                {"email", n => { Email = n.GetStringValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"login", n => { Login = n.GetStringValue(); } },
                {"offline_image_url", n => { OfflineImageUrl = n.GetStringValue(); } },
                {"profile_image_url", n => { ProfileImageUrl = n.GetStringValue(); } },
                {"type", n => { Type = n.GetStringValue(); } },
                {"view_count", n => { ViewCount = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("broadcaster_type", BroadcasterType);
            writer.WriteStringValue("created_at", CreatedAt);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("display_name", DisplayName);
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("login", Login);
            writer.WriteStringValue("offline_image_url", OfflineImageUrl);
            writer.WriteStringValue("profile_image_url", ProfileImageUrl);
            writer.WriteStringValue("type", Type);
            writer.WriteDoubleValue("view_count", ViewCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
