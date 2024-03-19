// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace TheOmenDen.CorvidDelivery.Twitch.Streams.Tags {
    public class TagsGetResponse_data_localization_names : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The bgBg property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BgBg { get; set; }
#nullable restore
#else
        public string BgBg { get; set; }
#endif
        /// <summary>The csCz property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CsCz { get; set; }
#nullable restore
#else
        public string CsCz { get; set; }
#endif
        /// <summary>The daDk property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DaDk { get; set; }
#nullable restore
#else
        public string DaDk { get; set; }
#endif
        /// <summary>The deDe property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeDe { get; set; }
#nullable restore
#else
        public string DeDe { get; set; }
#endif
        /// <summary>The elGr property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ElGr { get; set; }
#nullable restore
#else
        public string ElGr { get; set; }
#endif
        /// <summary>The enUs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EnUs { get; set; }
#nullable restore
#else
        public string EnUs { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="TagsGetResponse_data_localization_names"/> and sets the default values.
        /// </summary>
        public TagsGetResponse_data_localization_names() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="TagsGetResponse_data_localization_names"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TagsGetResponse_data_localization_names CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TagsGetResponse_data_localization_names();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"bg-bg", n => { BgBg = n.GetStringValue(); } },
                {"cs-cz", n => { CsCz = n.GetStringValue(); } },
                {"da-dk", n => { DaDk = n.GetStringValue(); } },
                {"de-de", n => { DeDe = n.GetStringValue(); } },
                {"el-gr", n => { ElGr = n.GetStringValue(); } },
                {"en-us", n => { EnUs = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("bg-bg", BgBg);
            writer.WriteStringValue("cs-cz", CsCz);
            writer.WriteStringValue("da-dk", DaDk);
            writer.WriteStringValue("de-de", DeDe);
            writer.WriteStringValue("el-gr", ElGr);
            writer.WriteStringValue("en-us", EnUs);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
