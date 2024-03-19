// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace TheOmenDen.CorvidDelivery.Twitch.Tags.Streams {
    public class StreamsGetResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The data property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<StreamsGetResponse_data>? Data { get; set; }
#nullable restore
#else
        public List<StreamsGetResponse_data> Data { get; set; }
#endif
        /// <summary>The pagination property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public StreamsGetResponse_pagination? Pagination { get; set; }
#nullable restore
#else
        public StreamsGetResponse_pagination Pagination { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="StreamsGetResponse"/> and sets the default values.
        /// </summary>
        public StreamsGetResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="StreamsGetResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static StreamsGetResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new StreamsGetResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"data", n => { Data = n.GetCollectionOfObjectValues<StreamsGetResponse_data>(StreamsGetResponse_data.CreateFromDiscriminatorValue)?.ToList(); } },
                {"pagination", n => { Pagination = n.GetObjectValue<StreamsGetResponse_pagination>(StreamsGetResponse_pagination.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<StreamsGetResponse_data>("data", Data);
            writer.WriteObjectValue<StreamsGetResponse_pagination>("pagination", Pagination);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
