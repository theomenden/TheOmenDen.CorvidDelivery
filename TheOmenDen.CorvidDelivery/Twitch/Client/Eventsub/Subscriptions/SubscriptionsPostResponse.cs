// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace TheOmenDen.CorvidDelivery.Twitch.Eventsub.Subscriptions {
    public class SubscriptionsPostResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The data property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SubscriptionsPostResponse_data>? Data { get; set; }
#nullable restore
#else
        public List<SubscriptionsPostResponse_data> Data { get; set; }
#endif
        /// <summary>The max_total_cost property</summary>
        public double? MaxTotalCost { get; set; }
        /// <summary>The total property</summary>
        public double? Total { get; set; }
        /// <summary>The total_cost property</summary>
        public double? TotalCost { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="SubscriptionsPostResponse"/> and sets the default values.
        /// </summary>
        public SubscriptionsPostResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="SubscriptionsPostResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SubscriptionsPostResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SubscriptionsPostResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"data", n => { Data = n.GetCollectionOfObjectValues<SubscriptionsPostResponse_data>(SubscriptionsPostResponse_data.CreateFromDiscriminatorValue)?.ToList(); } },
                {"max_total_cost", n => { MaxTotalCost = n.GetDoubleValue(); } },
                {"total", n => { Total = n.GetDoubleValue(); } },
                {"total_cost", n => { TotalCost = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<SubscriptionsPostResponse_data>("data", Data);
            writer.WriteDoubleValue("max_total_cost", MaxTotalCost);
            writer.WriteDoubleValue("total", Total);
            writer.WriteDoubleValue("total_cost", TotalCost);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
