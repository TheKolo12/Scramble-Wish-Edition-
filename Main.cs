using Exiled.API.Features;
using Exiled.CustomItems;
using Exiled.CustomItems.API.Features;
using System;
//:)
namespace Scramble
{
    public class Main : Plugin<Config>
    {
        public override string Name => "Scramble (Wish Edition)";
        public override string Author => "Kolo";
        public override string Prefix => "Scramble";
        public override Version RequiredExiledVersion => new Version(9, 5, 2);

        public static Main Instance { get; private set; }

        public override void OnEnabled()
        {
            Instance = this;
            CustomItem.RegisterItems();
            ScrambleItem.Instance?.RegisterEvents();
            Log.Debug("Scramble (Wish Edition) Enabled");
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Instance = null;
            CustomItem.UnregisterItems();
            ScrambleItem.Instance.RegisterEvents();
            Log.Debug("Scramble (Wish Edition) disabled.");
            base.OnDisabled();
        }
    }
}
