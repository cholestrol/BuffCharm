using Terraria.ID;

namespace BuffCharm.Items.Small
{
    class SwiftnessCharm : _BaseSmallCharm
    {
        public override string Description => "Grants Swiftness buff while equipped";
        public override int[] Buffs => new int[] { BuffID.Swiftness };
        public override int[,] PotionsCraftedFrom => new int[,]
        {
            { ItemID.SwiftnessPotion }
        };
    }
}
