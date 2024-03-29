// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace TheOmenDen.CorvidDelivery.Twitch.Users.Extensions {
    public class ExtensionsPutResponse_data_overlay : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The One property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ExtensionsPutResponse_data_overlay_One? One { get; set; }
#nullable restore
#else
        public ExtensionsPutResponse_data_overlay_One One { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="ExtensionsPutResponse_data_overlay"/> and sets the default values.
        /// </summary>
        public ExtensionsPutResponse_data_overlay() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ExtensionsPutResponse_data_overlay"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ExtensionsPutResponse_data_overlay CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExtensionsPutResponse_data_overlay();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"1", n => { One = n.GetObjectValue<ExtensionsPutResponse_data_overlay_One>(ExtensionsPutResponse_data_overlay_One.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ExtensionsPutResponse_data_overlay_One>("1", One);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
