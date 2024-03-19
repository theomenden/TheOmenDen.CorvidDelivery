// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace TheOmenDen.CorvidDelivery.TiltifyApi.Models {
    /// <summary>
    /// An object with various social usernames and links
    /// </summary>
    public class Social : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Discord invite url</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Discord { get; set; }
#nullable restore
#else
        public string Discord { get; set; }
#endif
        /// <summary>Facebook Page username</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Facebook { get; set; }
#nullable restore
#else
        public string Facebook { get; set; }
#endif
        /// <summary>Instagram username</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Instagram { get; set; }
#nullable restore
#else
        public string Instagram { get; set; }
#endif
        /// <summary>Snapchat username</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Snapchat { get; set; }
#nullable restore
#else
        public string Snapchat { get; set; }
#endif
        /// <summary>TikTok username</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Tiktok { get; set; }
#nullable restore
#else
        public string Tiktok { get; set; }
#endif
        /// <summary>Twitch username</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Twitch { get; set; }
#nullable restore
#else
        public string Twitch { get; set; }
#endif
        /// <summary>Twitter username</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Twitter { get; set; }
#nullable restore
#else
        public string Twitter { get; set; }
#endif
        /// <summary>Custom website url</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Website { get; set; }
#nullable restore
#else
        public string Website { get; set; }
#endif
        /// <summary>Youtube channel ID</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Youtube { get; set; }
#nullable restore
#else
        public string Youtube { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Social"/> and sets the default values.
        /// </summary>
        public Social() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Social"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Social CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Social();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"discord", n => { Discord = n.GetStringValue(); } },
                {"facebook", n => { Facebook = n.GetStringValue(); } },
                {"instagram", n => { Instagram = n.GetStringValue(); } },
                {"snapchat", n => { Snapchat = n.GetStringValue(); } },
                {"tiktok", n => { Tiktok = n.GetStringValue(); } },
                {"twitch", n => { Twitch = n.GetStringValue(); } },
                {"twitter", n => { Twitter = n.GetStringValue(); } },
                {"website", n => { Website = n.GetStringValue(); } },
                {"youtube", n => { Youtube = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("discord", Discord);
            writer.WriteStringValue("facebook", Facebook);
            writer.WriteStringValue("instagram", Instagram);
            writer.WriteStringValue("snapchat", Snapchat);
            writer.WriteStringValue("tiktok", Tiktok);
            writer.WriteStringValue("twitch", Twitch);
            writer.WriteStringValue("twitter", Twitter);
            writer.WriteStringValue("website", Website);
            writer.WriteStringValue("youtube", Youtube);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
