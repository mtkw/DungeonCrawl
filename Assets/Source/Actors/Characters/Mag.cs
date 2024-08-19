using DungeonCrawl.Actors;
using DungeonCrawl.Actors.Characters;
using System;
using UnityEngine;

namespace DungeonCrawl.Actors.Characters
{
    public class Mag : Character
    {
        public Mag()
        {
            base.SetInitialHealth(6);
            base.SetInitialArmor();
            base.SetHitValue(4);
        }

        public override bool OnCollision(Actor anotherActor)
        {
            if(anotherActor is Player)
            {
                Character player = (Character)anotherActor;
                this.ApplyDamage(player.Hit);
                player.ApplyDamage(this.Hit);
            }
            return false;
        }

        protected override void OnDeath()
        {
            Debug.Log("Well, I was already dead anyway...");
        }

        public override int DefaultSpriteId => 311;
        public override string DefaultName => "Mag";
    }
}
