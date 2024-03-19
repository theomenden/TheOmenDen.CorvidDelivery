// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace TheOmenDen.CorvidDelivery.TiltifyApi.Models {
    public class Schedule : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Campaign schedule description</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Moment when the schedule ends in ISO8601 format</summary>
        public DateTimeOffset? EndsAt { get; set; }
        /// <summary>Unique Identifier for the milestone.</summary>
        public Guid? Id { get; set; }
        /// <summary>Moment when the milestone was created</summary>
        public DateTimeOffset? InsertedAt { get; set; }
        /// <summary>Legacy numeric ID of the object. If your app is dependent on this field, please migrate to id. This will be deprecated in the next version of the API.</summary>
        [Obsolete("")]
        public double? LegacyId { get; set; }
        /// <summary>Milestone name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Moment when the schedule starts in ISO8601 format</summary>
        public DateTimeOffset? StartsAt { get; set; }
        /// <summary>Moment when the milestone was last updated</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="Schedule"/> and sets the default values.
        /// </summary>
        public Schedule() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Schedule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Schedule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Schedule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"description", n => { Description = n.GetStringValue(); } },
                {"ends_at", n => { EndsAt = n.GetDateTimeOffsetValue(); } },
                {"id", n => { Id = n.GetGuidValue(); } },
                {"inserted_at", n => { InsertedAt = n.GetDateTimeOffsetValue(); } },
                {"legacy_id", n => { LegacyId = n.GetDoubleValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"starts_at", n => { StartsAt = n.GetDateTimeOffsetValue(); } },
                {"updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteDateTimeOffsetValue("ends_at", EndsAt);
            writer.WriteGuidValue("id", Id);
            writer.WriteDateTimeOffsetValue("inserted_at", InsertedAt);
            writer.WriteDoubleValue("legacy_id", LegacyId);
            writer.WriteStringValue("name", Name);
            writer.WriteDateTimeOffsetValue("starts_at", StartsAt);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
