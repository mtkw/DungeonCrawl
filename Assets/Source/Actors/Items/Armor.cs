namespace DungeonCrawl.Actors.Items
{
    public class Armor : Actor
    {
        public override int DefaultSpriteId => 34;
        public override string DefaultName => "Armor";

        public override bool Detectable => false;
    }
}
