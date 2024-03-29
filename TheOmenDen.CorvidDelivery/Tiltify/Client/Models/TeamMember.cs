// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace TheOmenDen.CorvidDelivery.TiltifyApi.Models {
    public class TeamMember : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Unique Identifier for the Object. UUID</summary>
        public Guid? Id { get; set; }
        /// <summary>When the team member was created</summary>
        public DateTimeOffset? InsertedAt { get; set; }
        /// <summary>Legacy numeric ID of the object. If your app is dependent on this field, please migrate to id. This will be deprecated in the next version of the API.</summary>
        [Obsolete("")]
        public double? LegacyId { get; set; }
        /// <summary>A list of the team member&apos;s roles</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Role>? Roles { get; set; }
#nullable restore
#else
        public List<Role> Roles { get; set; }
#endif
        /// <summary>When the team member was last updated</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>The user property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TheOmenDen.CorvidDelivery.TiltifyApi.Models.User? User { get; set; }
#nullable restore
#else
        public TheOmenDen.CorvidDelivery.TiltifyApi.Models.User User { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="TeamMember"/> and sets the default values.
        /// </summary>
        public TeamMember() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="TeamMember"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TeamMember CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamMember();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"id", n => { Id = n.GetGuidValue(); } },
                {"inserted_at", n => { InsertedAt = n.GetDateTimeOffsetValue(); } },
                {"legacy_id", n => { LegacyId = n.GetDoubleValue(); } },
                {"roles", n => { Roles = n.GetCollectionOfObjectValues<Role>(Role.CreateFromDiscriminatorValue)?.ToList(); } },
                {"updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                {"user", n => { User = n.GetObjectValue<TheOmenDen.CorvidDelivery.TiltifyApi.Models.User>(TheOmenDen.CorvidDelivery.TiltifyApi.Models.User.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteGuidValue("id", Id);
            writer.WriteDateTimeOffsetValue("inserted_at", InsertedAt);
            writer.WriteDoubleValue("legacy_id", LegacyId);
            writer.WriteCollectionOfObjectValues<Role>("roles", Roles);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteObjectValue<TheOmenDen.CorvidDelivery.TiltifyApi.Models.User>("user", User);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
