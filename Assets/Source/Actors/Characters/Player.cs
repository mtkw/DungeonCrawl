using System.Collections.Generic;
using UnityEngine;

namespace DungeonCrawl.Actors.Characters
{
    public class Player : Character
    {
        public List<Item> Inventory = new List<Item>();

        public Player() 
        {
            base.SetInitialHealth(10);
            base.SetInitialArmor();
            base.SetHitValue(2);
        }
        protected override void OnUpdate(float deltaTime)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                // Move up
                TryMove(Direction.Up);
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                // Move down
                TryMove(Direction.Down);
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                // Move left
                TryMove(Direction.Left);
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                // Move right
                TryMove(Direction.Right);
            }
            if (Input.GetKeyDown(KeyCode.E)) {
                foreach (Item item in Inventory) { Debug.Log(item.ItemType.ToString()); }
            }
            if (Input.GetKeyDown(KeyCode.I))
            {
                Debug.Log("Player Health: " + this.Health);
                Debug.Log("Player Armor: " + this.Armor);
                Debug.Log("Player Hit Points: " + this.Hit);
            }
        }

        public override bool OnCollision(Actor anotherActor)
        {
            if (anotherActor.DefaultName == "Wall")
            {
                return true;
            }
            if (anotherActor is Character) { 
               Character character = (Character)anotherActor;
               this.ApplyDamage(character.Hit);
               character.ApplyDamage(this.Hit);
            }
            return false;
        }

        protected override void OnDeath()
        {
            Debug.Log("Oh no, I'm dead!");
        }

        public override int DefaultSpriteId => 24;
        public override string DefaultName => "Player";
    }
}
