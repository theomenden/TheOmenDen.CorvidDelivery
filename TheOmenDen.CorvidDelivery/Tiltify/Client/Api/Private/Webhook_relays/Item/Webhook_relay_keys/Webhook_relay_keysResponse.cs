// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace TheOmenDen.CorvidDelivery.TiltifyApi.Api.Private.Webhook_relays.Item.Webhook_relay_keys {
    [Obsolete("This class is obsolete. Use Webhook_relay_keysGetResponse instead.")]
    public class Webhook_relay_keysResponse : Webhook_relay_keysGetResponse, IParsable {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Webhook_relay_keysResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Webhook_relay_keysResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Webhook_relay_keysResponse();
        }
    }
}
