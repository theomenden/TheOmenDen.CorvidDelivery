// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace TheOmenDen.CorvidDelivery.TiltifyApi.Models {
    public class WebhookSubscription : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The ID for the Event this subscription belongs to</summary>
        public Guid? EventId { get; set; }
        /// <summary>The list of event types this subscription is subscribed to</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WebhookSubscription_event_types?>? EventTypes { get; set; }
#nullable restore
#else
        public List<WebhookSubscription_event_types?> EventTypes { get; set; }
#endif
        /// <summary>Unique Identifier for the Object. UUID</summary>
        public Guid? Id { get; set; }
        /// <summary>When the webhook subscription was created</summary>
        public DateTimeOffset? InsertedAt { get; set; }
        /// <summary>When the webhook subscription was last updated</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>The ID for the WebhookEndpoint this subscription belongs to</summary>
        public Guid? WebhookEndpointId { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="WebhookSubscription"/> and sets the default values.
        /// </summary>
        public WebhookSubscription() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="WebhookSubscription"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WebhookSubscription CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WebhookSubscription();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"event_id", n => { EventId = n.GetGuidValue(); } },
                {"event_types", n => { EventTypes = n.GetCollectionOfEnumValues<WebhookSubscription_event_types>()?.ToList(); } },
                {"id", n => { Id = n.GetGuidValue(); } },
                {"inserted_at", n => { InsertedAt = n.GetDateTimeOffsetValue(); } },
                {"updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                {"webhook_endpoint_id", n => { WebhookEndpointId = n.GetGuidValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteGuidValue("event_id", EventId);
            writer.WriteCollectionOfEnumValues<WebhookSubscription_event_types>("event_types", EventTypes);
            writer.WriteGuidValue("id", Id);
            writer.WriteDateTimeOffsetValue("inserted_at", InsertedAt);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteGuidValue("webhook_endpoint_id", WebhookEndpointId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
