// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace TheOmenDen.CorvidDelivery.Twitch.Chat.Settings {
    public class SettingsGetResponse_data : IAdditionalDataHolder, IParsable {
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
        /// <summary>The emote_mode property</summary>
        public bool? EmoteMode { get; set; }
        /// <summary>The follower_mode property</summary>
        public bool? FollowerMode { get; set; }
        /// <summary>The follower_mode_duration property</summary>
        public double? FollowerModeDuration { get; set; }
        /// <summary>The non_moderator_chat_delay property</summary>
        public bool? NonModeratorChatDelay { get; set; }
        /// <summary>The non_moderator_chat_delay_duration property</summary>
        public double? NonModeratorChatDelayDuration { get; set; }
        /// <summary>The slow_mode property</summary>
        public bool? SlowMode { get; set; }
        /// <summary>The slow_mode_wait_time property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SlowModeWaitTime { get; set; }
#nullable restore
#else
        public string SlowModeWaitTime { get; set; }
#endif
        /// <summary>The subscriber_mode property</summary>
        public bool? SubscriberMode { get; set; }
        /// <summary>The unique_chat_mode property</summary>
        public bool? UniqueChatMode { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="SettingsGetResponse_data"/> and sets the default values.
        /// </summary>
        public SettingsGetResponse_data() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="SettingsGetResponse_data"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SettingsGetResponse_data CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SettingsGetResponse_data();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"broadcaster_id", n => { BroadcasterId = n.GetStringValue(); } },
                {"emote_mode", n => { EmoteMode = n.GetBoolValue(); } },
                {"follower_mode", n => { FollowerMode = n.GetBoolValue(); } },
                {"follower_mode_duration", n => { FollowerModeDuration = n.GetDoubleValue(); } },
                {"non_moderator_chat_delay", n => { NonModeratorChatDelay = n.GetBoolValue(); } },
                {"non_moderator_chat_delay_duration", n => { NonModeratorChatDelayDuration = n.GetDoubleValue(); } },
                {"slow_mode", n => { SlowMode = n.GetBoolValue(); } },
                {"slow_mode_wait_time", n => { SlowModeWaitTime = n.GetStringValue(); } },
                {"subscriber_mode", n => { SubscriberMode = n.GetBoolValue(); } },
                {"unique_chat_mode", n => { UniqueChatMode = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("broadcaster_id", BroadcasterId);
            writer.WriteBoolValue("emote_mode", EmoteMode);
            writer.WriteBoolValue("follower_mode", FollowerMode);
            writer.WriteDoubleValue("follower_mode_duration", FollowerModeDuration);
            writer.WriteBoolValue("non_moderator_chat_delay", NonModeratorChatDelay);
            writer.WriteDoubleValue("non_moderator_chat_delay_duration", NonModeratorChatDelayDuration);
            writer.WriteBoolValue("slow_mode", SlowMode);
            writer.WriteStringValue("slow_mode_wait_time", SlowModeWaitTime);
            writer.WriteBoolValue("subscriber_mode", SubscriberMode);
            writer.WriteBoolValue("unique_chat_mode", UniqueChatMode);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
