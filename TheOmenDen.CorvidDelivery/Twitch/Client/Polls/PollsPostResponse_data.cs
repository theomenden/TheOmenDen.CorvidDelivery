// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace TheOmenDen.CorvidDelivery.Twitch.Polls {
    public class PollsPostResponse_data : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The bits_per_vote property</summary>
        public double? BitsPerVote { get; set; }
        /// <summary>The bits_voting_enabled property</summary>
        public bool? BitsVotingEnabled { get; set; }
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
        /// <summary>The channel_points_per_vote property</summary>
        public double? ChannelPointsPerVote { get; set; }
        /// <summary>The channel_points_voting_enabled property</summary>
        public bool? ChannelPointsVotingEnabled { get; set; }
        /// <summary>The choices property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PollsPostResponse_data_choices>? Choices { get; set; }
#nullable restore
#else
        public List<PollsPostResponse_data_choices> Choices { get; set; }
#endif
        /// <summary>The duration property</summary>
        public double? Duration { get; set; }
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The started_at property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StartedAt { get; set; }
#nullable restore
#else
        public string StartedAt { get; set; }
#endif
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
        /// <summary>
        /// Instantiates a new <see cref="PollsPostResponse_data"/> and sets the default values.
        /// </summary>
        public PollsPostResponse_data() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PollsPostResponse_data"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PollsPostResponse_data CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PollsPostResponse_data();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"bits_per_vote", n => { BitsPerVote = n.GetDoubleValue(); } },
                {"bits_voting_enabled", n => { BitsVotingEnabled = n.GetBoolValue(); } },
                {"broadcaster_id", n => { BroadcasterId = n.GetStringValue(); } },
                {"broadcaster_login", n => { BroadcasterLogin = n.GetStringValue(); } },
                {"broadcaster_name", n => { BroadcasterName = n.GetStringValue(); } },
                {"channel_points_per_vote", n => { ChannelPointsPerVote = n.GetDoubleValue(); } },
                {"channel_points_voting_enabled", n => { ChannelPointsVotingEnabled = n.GetBoolValue(); } },
                {"choices", n => { Choices = n.GetCollectionOfObjectValues<PollsPostResponse_data_choices>(PollsPostResponse_data_choices.CreateFromDiscriminatorValue)?.ToList(); } },
                {"duration", n => { Duration = n.GetDoubleValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"started_at", n => { StartedAt = n.GetStringValue(); } },
                {"status", n => { Status = n.GetStringValue(); } },
                {"title", n => { Title = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("bits_per_vote", BitsPerVote);
            writer.WriteBoolValue("bits_voting_enabled", BitsVotingEnabled);
            writer.WriteStringValue("broadcaster_id", BroadcasterId);
            writer.WriteStringValue("broadcaster_login", BroadcasterLogin);
            writer.WriteStringValue("broadcaster_name", BroadcasterName);
            writer.WriteDoubleValue("channel_points_per_vote", ChannelPointsPerVote);
            writer.WriteBoolValue("channel_points_voting_enabled", ChannelPointsVotingEnabled);
            writer.WriteCollectionOfObjectValues<PollsPostResponse_data_choices>("choices", Choices);
            writer.WriteDoubleValue("duration", Duration);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("started_at", StartedAt);
            writer.WriteStringValue("status", Status);
            writer.WriteStringValue("title", Title);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
