using Terraria.ID;

namespace BuffCharm.Items.Small
{
    class FlipperCharm : _BaseSmallCharm
    {
        public override string Description => "Grants Flipper buff while equipped";
        public override int[] Buffs => new int[] { BuffID.Flipper };
        public override int[,] PotionsCraftedFrom => new int[,]
        {
            { ItemID.FlipperPotion }
        };
    }
}
