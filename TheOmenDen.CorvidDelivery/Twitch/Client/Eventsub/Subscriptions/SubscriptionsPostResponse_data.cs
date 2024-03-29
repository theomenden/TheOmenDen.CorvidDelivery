// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace TheOmenDen.CorvidDelivery.Twitch.Eventsub.Subscriptions {
    public class SubscriptionsPostResponse_data : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The condition property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SubscriptionsPostResponse_data_condition? Condition { get; set; }
#nullable restore
#else
        public SubscriptionsPostResponse_data_condition Condition { get; set; }
#endif
        /// <summary>The cost property</summary>
        public double? Cost { get; set; }
        /// <summary>The created_at property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedAt { get; set; }
#nullable restore
#else
        public string CreatedAt { get; set; }
#endif
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The status property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status { get; set; }
#nullable restore
#else
        public string Status { get; set; }
#endif
        /// <summary>The transport property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SubscriptionsPostResponse_data_transport? Transport { get; set; }
#nullable restore
#else
        public SubscriptionsPostResponse_data_transport Transport { get; set; }
#endif
        /// <summary>The type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>The version property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version { get; set; }
#nullable restore
#else
        public string Version { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="SubscriptionsPostResponse_data"/> and sets the default values.
        /// </summary>
        public SubscriptionsPostResponse_data() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="SubscriptionsPostResponse_data"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SubscriptionsPostResponse_data CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SubscriptionsPostResponse_data();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"condition", n => { Condition = n.GetObjectValue<SubscriptionsPostResponse_data_condition>(SubscriptionsPostResponse_data_condition.CreateFromDiscriminatorValue); } },
                {"cost", n => { Cost = n.GetDoubleValue(); } },
                {"created_at", n => { CreatedAt = n.GetStringValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"status", n => { Status = n.GetStringValue(); } },
                {"transport", n => { Transport = n.GetObjectValue<SubscriptionsPostResponse_data_transport>(SubscriptionsPostResponse_data_transport.CreateFromDiscriminatorValue); } },
                {"type", n => { Type = n.GetStringValue(); } },
                {"version", n => { Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<SubscriptionsPostResponse_data_condition>("condition", Condition);
            writer.WriteDoubleValue("cost", Cost);
            writer.WriteStringValue("created_at", CreatedAt);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("status", Status);
            writer.WriteObjectValue<SubscriptionsPostResponse_data_transport>("transport", Transport);
            writer.WriteStringValue("type", Type);
            writer.WriteStringValue("version", Version);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
