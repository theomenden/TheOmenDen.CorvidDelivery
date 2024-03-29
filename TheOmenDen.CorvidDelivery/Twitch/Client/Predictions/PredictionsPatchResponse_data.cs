// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace TheOmenDen.CorvidDelivery.Twitch.Predictions {
    public class PredictionsPatchResponse_data : IAdditionalDataHolder, IParsable {
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
        /// <summary>The created_at property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedAt { get; set; }
#nullable restore
#else
        public string CreatedAt { get; set; }
#endif
        /// <summary>The ended_at property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EndedAt { get; set; }
#nullable restore
#else
        public string EndedAt { get; set; }
#endif
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The locked_at property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LockedAt { get; set; }
#nullable restore
#else
        public string LockedAt { get; set; }
#endif
        /// <summary>The outcomes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PredictionsPatchResponse_data_outcomes>? Outcomes { get; set; }
#nullable restore
#else
        public List<PredictionsPatchResponse_data_outcomes> Outcomes { get; set; }
#endif
        /// <summary>The prediction_window property</summary>
        public double? PredictionWindow { get; set; }
        /// <summary>The status property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status { get; set; }
#nullable restore
#else
        public string Status { get; set; }
#endif
        /// <summary>The title property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
#endif
        /// <summary>The winning_outcome_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WinningOutcomeId { get; set; }
#nullable restore
#else
        public string WinningOutcomeId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="PredictionsPatchResponse_data"/> and sets the default values.
        /// </summary>
        public PredictionsPatchResponse_data() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PredictionsPatchResponse_data"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PredictionsPatchResponse_data CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PredictionsPatchResponse_data();
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
                {"created_at", n => { CreatedAt = n.GetStringValue(); } },
                {"ended_at", n => { EndedAt = n.GetStringValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"locked_at", n => { LockedAt = n.GetStringValue(); } },
                {"outcomes", n => { Outcomes = n.GetCollectionOfObjectValues<PredictionsPatchResponse_data_outcomes>(PredictionsPatchResponse_data_outcomes.CreateFromDiscriminatorValue)?.ToList(); } },
                {"prediction_window", n => { PredictionWindow = n.GetDoubleValue(); } },
                {"status", n => { Status = n.GetStringValue(); } },
                {"title", n => { Title = n.GetStringValue(); } },
                {"winning_outcome_id", n => { WinningOutcomeId = n.GetStringValue(); } },
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
            writer.WriteStringValue("created_at", CreatedAt);
            writer.WriteStringValue("ended_at", EndedAt);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("locked_at", LockedAt);
            writer.WriteCollectionOfObjectValues<PredictionsPatchResponse_data_outcomes>("outcomes", Outcomes);
            writer.WriteDoubleValue("prediction_window", PredictionWindow);
            writer.WriteStringValue("status", Status);
            writer.WriteStringValue("title", Title);
            writer.WriteStringValue("winning_outcome_id", WinningOutcomeId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
