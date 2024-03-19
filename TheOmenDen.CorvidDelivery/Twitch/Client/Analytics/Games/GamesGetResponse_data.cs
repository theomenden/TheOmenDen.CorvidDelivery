// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace TheOmenDen.CorvidDelivery.Twitch.Analytics.Games {
    public class GamesGetResponse_data : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The date_range property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GamesGetResponse_data_date_range? DateRange { get; set; }
#nullable restore
#else
        public GamesGetResponse_data_date_range DateRange { get; set; }
#endif
        /// <summary>The game_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GameId { get; set; }
#nullable restore
#else
        public string GameId { get; set; }
#endif
        /// <summary>The type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>The URL property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? URL { get; set; }
#nullable restore
#else
        public string URL { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="GamesGetResponse_data"/> and sets the default values.
        /// </summary>
        public GamesGetResponse_data() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="GamesGetResponse_data"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static GamesGetResponse_data CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GamesGetResponse_data();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"date_range", n => { DateRange = n.GetObjectValue<GamesGetResponse_data_date_range>(GamesGetResponse_data_date_range.CreateFromDiscriminatorValue); } },
                {"game_id", n => { GameId = n.GetStringValue(); } },
                {"type", n => { Type = n.GetStringValue(); } },
                {"URL", n => { URL = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<GamesGetResponse_data_date_range>("date_range", DateRange);
            writer.WriteStringValue("game_id", GameId);
            writer.WriteStringValue("type", Type);
            writer.WriteStringValue("URL", URL);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
