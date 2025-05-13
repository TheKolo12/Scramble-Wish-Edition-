using Exiled.API.Features;
using Exiled.API.Features.Attributes;
using Exiled.API.Features.Spawn;
using Exiled.CustomItems.API.Features;
using Exiled.Events.Handlers;
using Exiled.Events.EventArgs.Scp096;
using InventorySystem.Items;
using PlayerRoles;
using System.Collections.Generic;
using System.Linq;
using Exiled.API.Features.Items;
using static PlayerList;

//:)
namespace Scramble
{
    [CustomItem(ItemType.Coin)]
    public class ScrambleItem : CustomItem
    {
        public ScrambleItem()
        {
            Instance = this;
        }
        public override uint Id { get; set; } = 324;
        public override string Name { get; set; } = "Scramble";
        public override string Description { get; set; } = "Wear them and you will become invulnerable to SCP-096.";
        public override ItemType Type { get; set; } = ItemType.Coin;
        public override float Weight { get; set; } = 1f;

        public override SpawnProperties SpawnProperties { get; set; } = new SpawnProperties
        {
            DynamicSpawnPoints = Main.Instance.Config.SpawnLocations
                .Select(entry => new DynamicSpawnPoint
                {
                    Location = entry.Key,
                    Chance = entry.Value
                }).ToList()
        };
        public static ScrambleItem Instance { get; private set; }

        public void RegisterEvents()
        {
            Scp096.AddingTarget += OnAddingTarget;
        }

        public void UnregisterEvents()
        {
            Scp096.AddingTarget -= OnAddingTarget;
        }

        private void OnAddingTarget(AddingTargetEventArgs ev)
        {
            if (ev.Target == null)
                return;

            foreach (var item in ev.Target.Items)
            {
                if (CustomItem.TryGet(item, out CustomItem customItem) && customItem is ScrambleItem)
                {
                    ev.IsAllowed = false;
                    Log.Debug($"{ev.Target.Nickname} has Scramble — ignored by SCP-096.");
                    return;
                }
            }
        }
    }
}
