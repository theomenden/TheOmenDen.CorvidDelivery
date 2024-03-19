// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace TheOmenDen.CorvidDelivery.Twitch.Bits.Leaderboard {
    [Obsolete("This class is obsolete. Use LeaderboardGetResponse instead.")]
    public class LeaderboardResponse : LeaderboardGetResponse, IParsable {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="LeaderboardResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new LeaderboardResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new LeaderboardResponse();
        }
    }
}
