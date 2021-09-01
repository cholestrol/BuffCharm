using Terraria.ID;

namespace BuffCharm.Items.Small
{
    class WarmthCharm : _BaseSmallCharm
    {
        public override string Description => "Grants Warmth buff while equipped";
        public override int[] Buffs => new int[] { BuffID.Warmth };
        public override int[,] PotionsCraftedFrom => new int[,]
        {
            { ItemID.WarmthPotion }
        };
    }
}
