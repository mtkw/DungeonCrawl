using DungeonCrawl.Actors.Characters;
using DungeonCrawl.Core;
using JetBrains.Annotations;
using UnityEngine;

namespace DungeonCrawl.Actors.Items
{
    public class Armor : Item
    {
        public override int DefaultSpriteId => 34;
        public override string DefaultName => "Armor";

        public override bool Detectable => true;

        public Armor() 
        { 
            base.ItemType = ItemType.Armor;
            base.ItemStatistic = 5;
            base.ItemCount = 1;
        }

        public override bool OnCollision(Actor anotherActor)
        {
            if (anotherActor is Player) {
                Debug.Log("Player found itme");
                Player player = (Player)anotherActor;
                player.Inventory.Add(this);
                player.SetArmor(this.ItemStatistic);
                ActorManager.Singleton.DestroyActor(this);
                return true;
            }
            return false;
        }

    }
}
