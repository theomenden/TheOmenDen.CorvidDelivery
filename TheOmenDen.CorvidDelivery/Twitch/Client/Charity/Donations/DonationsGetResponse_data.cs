// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace TheOmenDen.CorvidDelivery.Twitch.Charity.Donations {
    public class DonationsGetResponse_data : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The amount property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DonationsGetResponse_data_amount? Amount { get; set; }
#nullable restore
#else
        public DonationsGetResponse_data_amount Amount { get; set; }
#endif
        /// <summary>The campaign_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CampaignId { get; set; }
#nullable restore
#else
        public string CampaignId { get; set; }
#endif
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The user_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId { get; set; }
#nullable restore
#else
        public string UserId { get; set; }
#endif
        /// <summary>The user_login property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserLogin { get; set; }
#nullable restore
#else
        public string UserLogin { get; set; }
#endif
        /// <summary>The user_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserName { get; set; }
#nullable restore
#else
        public string UserName { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="DonationsGetResponse_data"/> and sets the default values.
        /// </summary>
        public DonationsGetResponse_data() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DonationsGetResponse_data"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DonationsGetResponse_data CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DonationsGetResponse_data();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"amount", n => { Amount = n.GetObjectValue<DonationsGetResponse_data_amount>(DonationsGetResponse_data_amount.CreateFromDiscriminatorValue); } },
                {"campaign_id", n => { CampaignId = n.GetStringValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"user_id", n => { UserId = n.GetStringValue(); } },
                {"user_login", n => { UserLogin = n.GetStringValue(); } },
                {"user_name", n => { UserName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<DonationsGetResponse_data_amount>("amount", Amount);
            writer.WriteStringValue("campaign_id", CampaignId);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("user_id", UserId);
            writer.WriteStringValue("user_login", UserLogin);
            writer.WriteStringValue("user_name", UserName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
