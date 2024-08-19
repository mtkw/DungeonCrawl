using DungeonCrawl.Core;

namespace DungeonCrawl.Actors.Characters
{
    public abstract class Character : Actor
    {
        public int Health { get; private set; }
        public int Hit {  get; private set; }
        public int Armor { get; private set; }

        public void ApplyDamage(int damage)
        {
            if(Armor > 0)
            {
                Armor -= damage;
            }
            else
            {
                Armor = 0;
                Health -= damage; 
            }
            if (Health <= 0)
            {
                // Die
                OnDeath();

                ActorManager.Singleton.DestroyActor(this);
            }
        }

        public int SetHitValue(int value)
        {
            return Hit = value;
        }

        public int SetInitialHealth(int initialValue)
        {
            Health = initialValue;
            return Health;
        }

        public int SetInitialArmor()
        {
            return Armor = 0;
        }

        public int SetArmor(int value)
        {
            return Armor += value;
        }

        public int RecoveryHealth(int value)
        {
            return Health += value;
        }

        public int IncreaseHitStats(int value)
        {
            return Hit += value;
        }

        protected abstract void OnDeath();

        /// <summary>
        ///     All characters are drawn "above" floor etc
        /// </summary>
        public override int Z => -1;
    }
}
