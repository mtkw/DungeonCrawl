using Assets.Source.Actors.Items;
using DungeonCrawl.Actors.Characters;
using DungeonCrawl.Core;
using JetBrains.Annotations;
using UnityEngine;

namespace DungeonCrawl.Actors.Items
{
    public class Sword : Item
    {
        public override int DefaultSpriteId => 129;
        public override string DefaultName => "Sword";

        public override bool Detectable => true;

        public Sword()
        {
            base.ItemType = ItemType.Weapon;
            base.ItemStatistic = 4;
            base.ItemCount = 1;
        }

        public override bool OnCollision(Actor anotherActor)
        {
            if (anotherActor is Player)
            {
                Debug.Log("Player found Sword");
                Player player = (Player)anotherActor;
                player.Inventory.Add(this);
                player.IncreaseHitStats(this.ItemStatistic);
                ActorManager.Singleton.DestroyActor(this);
                return true;
            }
            return false;
        }

    }
}
