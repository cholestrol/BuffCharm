using Terraria.ID;

namespace BuffCharm.Items.Small
{
    class SpelunkerCharm : _BaseSmallCharm
    {
        public override string Description => "Grants Spelunker buff while equipped";
        public override int[] Buffs => new int[] { BuffID.Spelunker };
        public override int[,] PotionsCraftedFrom => new int[,]
        {
            { ItemID.SpelunkerPotion }
        };
    }
}
