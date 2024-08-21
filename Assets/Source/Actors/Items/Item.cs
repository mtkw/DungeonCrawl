﻿

namespace DungeonCrawl.Actors.Characters
{
    public enum ItemType : byte
    {
        Potion,
        Armor,
        Weapon,
        Key
    }

    public abstract class Item : Actor
    {
        public ItemType ItemType;
        public int ItemStatistic;
        public int ItemCount;


    }

}
