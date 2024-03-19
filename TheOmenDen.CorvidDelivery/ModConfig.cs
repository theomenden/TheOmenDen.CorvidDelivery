using System;
using JetBrains.Annotations;
using StardewModdingAPI.Utilities;

namespace TheOmenDen.CorvidDelivery
{
    public sealed class ModConfig
    {
        [CanBeNull] public string Username { get; set; } = String.Empty;
        [CanBeNull] public string Password { get; set; } = String.Empty;
        [CanBeNull] public string Channel { get; set; } = String.Empty;
        [CanBeNull] public string ClientId { get; set; } = String.Empty;
        [CanBeNull] public string ClientSecret { get; set; } = String.Empty;
        [CanBeNull] public string OAuthToken { get; set; } = String.Empty;
        [CanBeNull] public string TwitchUsername { get; set; } = String.Empty;
        [CanBeNull] public string TwitchBotAccount { get; set; } = "crowbot36";
        public KeybindList ToggleKey { get; set; } = KeybindList.Parse("F7, LeftShift + U");
    }
}