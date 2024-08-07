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
    public class Orc : Character
    {
        private Direction currentDirection = Direction.Up;

        protected override void OnUpdate(float deltaTime)
        {
            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
            {
                if (currentDirection == Direction.Up)
                {
                    Debug.Log(currentDirection);
                    TryMove(Direction.Up);
                    currentDirection = Direction.Left;
                }
                else if (currentDirection == Direction.Left)
                {
                    Debug.Log(currentDirection);
                    TryMove(Direction.Left);
                    currentDirection = Direction.Down;
                }
                else if (currentDirection == Direction.Down)
                {
                    Debug.Log(currentDirection);
                    TryMove(Direction.Down);
                    currentDirection = Direction.Right;
                }
                else if (currentDirection == Direction.Right)
                {
                    Debug.Log(currentDirection);
                    TryMove(Direction.Right);
                    currentDirection = Direction.Up;
                }
            }
        }
        public override bool OnCollision(Actor anotherActor)
        {
            return false;
        }

        protected override void OnDeath()
        {
            Debug.Log("Well, I was already dead anyway...");
        }

        public override int DefaultSpriteId => 317;
        public override string DefaultName => "Orc";
    }
}
