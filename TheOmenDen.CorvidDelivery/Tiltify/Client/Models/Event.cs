// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace TheOmenDen.CorvidDelivery.TiltifyApi.Models {
    /// <summary>
    /// Composed type wrapper for classes <see cref="Campaign"/>, <see cref="TeamCampaign"/>
    /// </summary>
    public class Event : IComposedTypeWrapper, IParsable {
        /// <summary>Composed type representation for type <see cref="TheOmenDen.CorvidDelivery.TiltifyApi.Models.Campaign"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TheOmenDen.CorvidDelivery.TiltifyApi.Models.Campaign? Campaign { get; set; }
#nullable restore
#else
        public TheOmenDen.CorvidDelivery.TiltifyApi.Models.Campaign Campaign { get; set; }
#endif
        /// <summary>Composed type representation for type <see cref="TheOmenDen.CorvidDelivery.TiltifyApi.Models.Campaign"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TheOmenDen.CorvidDelivery.TiltifyApi.Models.Campaign? EventCampaign { get; set; }
#nullable restore
#else
        public TheOmenDen.CorvidDelivery.TiltifyApi.Models.Campaign EventCampaign { get; set; }
#endif
        /// <summary>Composed type representation for type <see cref="TheOmenDen.CorvidDelivery.TiltifyApi.Models.TeamCampaign"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TheOmenDen.CorvidDelivery.TiltifyApi.Models.TeamCampaign? EventTeamCampaign { get; set; }
#nullable restore
#else
        public TheOmenDen.CorvidDelivery.TiltifyApi.Models.TeamCampaign EventTeamCampaign { get; set; }
#endif
        /// <summary>Composed type representation for type <see cref="TheOmenDen.CorvidDelivery.TiltifyApi.Models.TeamCampaign"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TheOmenDen.CorvidDelivery.TiltifyApi.Models.TeamCampaign? TeamCampaign { get; set; }
#nullable restore
#else
        public TheOmenDen.CorvidDelivery.TiltifyApi.Models.TeamCampaign TeamCampaign { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Event"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Event CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
            var result = new Event();
            if("Campaign".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                result.Campaign = new TheOmenDen.CorvidDelivery.TiltifyApi.Models.Campaign();
            }
            else if("Campaign".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                result.EventCampaign = new TheOmenDen.CorvidDelivery.TiltifyApi.Models.Campaign();
            }
            else if("TeamCampaign".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                result.EventTeamCampaign = new TheOmenDen.CorvidDelivery.TiltifyApi.Models.TeamCampaign();
            }
            else if("TeamCampaign".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                result.TeamCampaign = new TheOmenDen.CorvidDelivery.TiltifyApi.Models.TeamCampaign();
            }
            return result;
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            if(Campaign != null) {
                return Campaign.GetFieldDeserializers();
            }
            else if(EventCampaign != null) {
                return EventCampaign.GetFieldDeserializers();
            }
            else if(EventTeamCampaign != null) {
                return EventTeamCampaign.GetFieldDeserializers();
            }
            else if(TeamCampaign != null) {
                return TeamCampaign.GetFieldDeserializers();
            }
            return new Dictionary<string, Action<IParseNode>>();
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            if(Campaign != null) {
                writer.WriteObjectValue<TheOmenDen.CorvidDelivery.TiltifyApi.Models.Campaign>(null, Campaign);
            }
            else if(EventCampaign != null) {
                writer.WriteObjectValue<TheOmenDen.CorvidDelivery.TiltifyApi.Models.Campaign>(null, EventCampaign);
            }
            else if(EventTeamCampaign != null) {
                writer.WriteObjectValue<TheOmenDen.CorvidDelivery.TiltifyApi.Models.TeamCampaign>(null, EventTeamCampaign);
            }
            else if(TeamCampaign != null) {
                writer.WriteObjectValue<TheOmenDen.CorvidDelivery.TiltifyApi.Models.TeamCampaign>(null, TeamCampaign);
            }
        }
    }
}
