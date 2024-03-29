// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace TheOmenDen.CorvidDelivery.Twitch.Chat.Badges {
    public class BadgesGetResponse_data_versions : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The click_action property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClickAction { get; set; }
#nullable restore
#else
        public string ClickAction { get; set; }
#endif
        /// <summary>The click_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClickUrl { get; set; }
#nullable restore
#else
        public string ClickUrl { get; set; }
#endif
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The image_url_1x property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ImageUrl1x { get; set; }
#nullable restore
#else
        public string ImageUrl1x { get; set; }
#endif
        /// <summary>The image_url_2x property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ImageUrl2x { get; set; }
#nullable restore
#else
        public string ImageUrl2x { get; set; }
#endif
        /// <summary>The image_url_4x property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ImageUrl4x { get; set; }
#nullable restore
#else
        public string ImageUrl4x { get; set; }
#endif
        /// <summary>The title property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="BadgesGetResponse_data_versions"/> and sets the default values.
        /// </summary>
        public BadgesGetResponse_data_versions() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="BadgesGetResponse_data_versions"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static BadgesGetResponse_data_versions CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BadgesGetResponse_data_versions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"click_action", n => { ClickAction = n.GetStringValue(); } },
                {"click_url", n => { ClickUrl = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"image_url_1x", n => { ImageUrl1x = n.GetStringValue(); } },
                {"image_url_2x", n => { ImageUrl2x = n.GetStringValue(); } },
                {"image_url_4x", n => { ImageUrl4x = n.GetStringValue(); } },
                {"title", n => { Title = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("click_action", ClickAction);
            writer.WriteStringValue("click_url", ClickUrl);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("image_url_1x", ImageUrl1x);
            writer.WriteStringValue("image_url_2x", ImageUrl2x);
            writer.WriteStringValue("image_url_4x", ImageUrl4x);
            writer.WriteStringValue("title", Title);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
