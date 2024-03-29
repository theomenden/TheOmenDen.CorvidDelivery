// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace TheOmenDen.CorvidDelivery.Twitch.Extensions.Transactions {
    public class TransactionsGetResponse_data : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The broadcaster_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BroadcasterId { get; set; }
#nullable restore
#else
        public string BroadcasterId { get; set; }
#endif
        /// <summary>The broadcaster_login property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BroadcasterLogin { get; set; }
#nullable restore
#else
        public string BroadcasterLogin { get; set; }
#endif
        /// <summary>The broadcaster_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BroadcasterName { get; set; }
#nullable restore
#else
        public string BroadcasterName { get; set; }
#endif
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The product_data property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TransactionsGetResponse_data_product_data? ProductData { get; set; }
#nullable restore
#else
        public TransactionsGetResponse_data_product_data ProductData { get; set; }
#endif
        /// <summary>The product_type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductType { get; set; }
#nullable restore
#else
        public string ProductType { get; set; }
#endif
        /// <summary>The timestamp property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Timestamp { get; set; }
#nullable restore
#else
        public string Timestamp { get; set; }
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
        /// Instantiates a new <see cref="TransactionsGetResponse_data"/> and sets the default values.
        /// </summary>
        public TransactionsGetResponse_data() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="TransactionsGetResponse_data"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TransactionsGetResponse_data CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TransactionsGetResponse_data();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"broadcaster_id", n => { BroadcasterId = n.GetStringValue(); } },
                {"broadcaster_login", n => { BroadcasterLogin = n.GetStringValue(); } },
                {"broadcaster_name", n => { BroadcasterName = n.GetStringValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"product_data", n => { ProductData = n.GetObjectValue<TransactionsGetResponse_data_product_data>(TransactionsGetResponse_data_product_data.CreateFromDiscriminatorValue); } },
                {"product_type", n => { ProductType = n.GetStringValue(); } },
                {"timestamp", n => { Timestamp = n.GetStringValue(); } },
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
            writer.WriteStringValue("broadcaster_id", BroadcasterId);
            writer.WriteStringValue("broadcaster_login", BroadcasterLogin);
            writer.WriteStringValue("broadcaster_name", BroadcasterName);
            writer.WriteStringValue("id", Id);
            writer.WriteObjectValue<TransactionsGetResponse_data_product_data>("product_data", ProductData);
            writer.WriteStringValue("product_type", ProductType);
            writer.WriteStringValue("timestamp", Timestamp);
            writer.WriteStringValue("user_id", UserId);
            writer.WriteStringValue("user_login", UserLogin);
            writer.WriteStringValue("user_name", UserName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
