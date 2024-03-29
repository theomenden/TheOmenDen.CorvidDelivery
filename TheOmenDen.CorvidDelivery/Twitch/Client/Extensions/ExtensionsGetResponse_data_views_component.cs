// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace TheOmenDen.CorvidDelivery.Twitch.Extensions {
    public class ExtensionsGetResponse_data_views_component : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The aspect_height property</summary>
        public double? AspectHeight { get; set; }
        /// <summary>The aspect_ratio_x property</summary>
        public double? AspectRatioX { get; set; }
        /// <summary>The aspect_ratio_y property</summary>
        public double? AspectRatioY { get; set; }
        /// <summary>The aspect_width property</summary>
        public double? AspectWidth { get; set; }
        /// <summary>The autoscale property</summary>
        public bool? Autoscale { get; set; }
        /// <summary>The can_link_external_content property</summary>
        public bool? CanLinkExternalContent { get; set; }
        /// <summary>The scale_pixels property</summary>
        public double? ScalePixels { get; set; }
        /// <summary>The size property</summary>
        public double? Size { get; set; }
        /// <summary>The target_height property</summary>
        public double? TargetHeight { get; set; }
        /// <summary>The viewer_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ViewerUrl { get; set; }
#nullable restore
#else
        public string ViewerUrl { get; set; }
#endif
        /// <summary>The zoom property</summary>
        public bool? Zoom { get; set; }
        /// <summary>The zoom_pixels property</summary>
        public double? ZoomPixels { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="ExtensionsGetResponse_data_views_component"/> and sets the default values.
        /// </summary>
        public ExtensionsGetResponse_data_views_component() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ExtensionsGetResponse_data_views_component"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ExtensionsGetResponse_data_views_component CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExtensionsGetResponse_data_views_component();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"aspect_height", n => { AspectHeight = n.GetDoubleValue(); } },
                {"aspect_ratio_x", n => { AspectRatioX = n.GetDoubleValue(); } },
                {"aspect_ratio_y", n => { AspectRatioY = n.GetDoubleValue(); } },
                {"aspect_width", n => { AspectWidth = n.GetDoubleValue(); } },
                {"autoscale", n => { Autoscale = n.GetBoolValue(); } },
                {"can_link_external_content", n => { CanLinkExternalContent = n.GetBoolValue(); } },
                {"scale_pixels", n => { ScalePixels = n.GetDoubleValue(); } },
                {"size", n => { Size = n.GetDoubleValue(); } },
                {"target_height", n => { TargetHeight = n.GetDoubleValue(); } },
                {"viewer_url", n => { ViewerUrl = n.GetStringValue(); } },
                {"zoom", n => { Zoom = n.GetBoolValue(); } },
                {"zoom_pixels", n => { ZoomPixels = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("aspect_height", AspectHeight);
            writer.WriteDoubleValue("aspect_ratio_x", AspectRatioX);
            writer.WriteDoubleValue("aspect_ratio_y", AspectRatioY);
            writer.WriteDoubleValue("aspect_width", AspectWidth);
            writer.WriteBoolValue("autoscale", Autoscale);
            writer.WriteBoolValue("can_link_external_content", CanLinkExternalContent);
            writer.WriteDoubleValue("scale_pixels", ScalePixels);
            writer.WriteDoubleValue("size", Size);
            writer.WriteDoubleValue("target_height", TargetHeight);
            writer.WriteStringValue("viewer_url", ViewerUrl);
            writer.WriteBoolValue("zoom", Zoom);
            writer.WriteDoubleValue("zoom_pixels", ZoomPixels);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
