using System;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;
namespace TheOmenDen.CorvidDelivery
{
    internal sealed class ModEntry : Mod
    {
        private ModConfig _config;

        public override void Entry(IModHelper helper)
        {
            _config = helper.ReadConfig<ModConfig>();
        }
    }
}