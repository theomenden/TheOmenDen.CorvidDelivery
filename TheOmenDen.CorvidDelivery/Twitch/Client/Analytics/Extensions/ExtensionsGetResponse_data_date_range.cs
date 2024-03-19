// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace TheOmenDen.CorvidDelivery.Twitch.Analytics.Extensions {
    public class ExtensionsGetResponse_data_date_range : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The ended_at property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EndedAt { get; set; }
#nullable restore
#else
        public string EndedAt { get; set; }
#endif
        /// <summary>The started_at property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StartedAt { get; set; }
#nullable restore
#else
        public string StartedAt { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="ExtensionsGetResponse_data_date_range"/> and sets the default values.
        /// </summary>
        public ExtensionsGetResponse_data_date_range() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ExtensionsGetResponse_data_date_range"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ExtensionsGetResponse_data_date_range CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExtensionsGetResponse_data_date_range();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"ended_at", n => { EndedAt = n.GetStringValue(); } },
                {"started_at", n => { StartedAt = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("ended_at", EndedAt);
            writer.WriteStringValue("started_at", StartedAt);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
