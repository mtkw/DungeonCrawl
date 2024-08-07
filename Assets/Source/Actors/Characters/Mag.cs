using DungeonCrawl.Actors;
using DungeonCrawl.Actors.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace DungeonCrawl.Actors.Characters
{
    public class Mag : Character
    {
        public override bool OnCollision(Actor anotherActor)
        {
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
