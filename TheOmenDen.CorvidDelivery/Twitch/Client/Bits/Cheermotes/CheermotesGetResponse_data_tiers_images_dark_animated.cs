// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace TheOmenDen.CorvidDelivery.Twitch.Bits.Cheermotes {
    public class CheermotesGetResponse_data_tiers_images_dark_animated : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Four property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Four { get; set; }
#nullable restore
#else
        public string Four { get; set; }
#endif
        /// <summary>The One property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? One { get; set; }
#nullable restore
#else
        public string One { get; set; }
#endif
        /// <summary>The OneFive property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OneFive { get; set; }
#nullable restore
#else
        public string OneFive { get; set; }
#endif
        /// <summary>The Three property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Three { get; set; }
#nullable restore
#else
        public string Three { get; set; }
#endif
        /// <summary>The Two property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Two { get; set; }
#nullable restore
#else
        public string Two { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="CheermotesGetResponse_data_tiers_images_dark_animated"/> and sets the default values.
        /// </summary>
        public CheermotesGetResponse_data_tiers_images_dark_animated() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CheermotesGetResponse_data_tiers_images_dark_animated"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CheermotesGetResponse_data_tiers_images_dark_animated CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CheermotesGetResponse_data_tiers_images_dark_animated();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"4", n => { Four = n.GetStringValue(); } },
                {"1", n => { One = n.GetStringValue(); } },
                {"1.5", n => { OneFive = n.GetStringValue(); } },
                {"3", n => { Three = n.GetStringValue(); } },
                {"2", n => { Two = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("4", Four);
            writer.WriteStringValue("1", One);
            writer.WriteStringValue("1.5", OneFive);
            writer.WriteStringValue("3", Three);
            writer.WriteStringValue("2", Two);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
