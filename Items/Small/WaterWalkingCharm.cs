using Terraria.ID;

namespace BuffCharm.Items.Small
{
    class WaterWalkingCharm : _BaseSmallCharm
    {
        public override string Description => "Grants Water Walking buff while equipped";
        public override int[] Buffs => new int[] { BuffID.WaterWalking };
        public override int[,] PotionsCraftedFrom => new int[,]
        {
            { ItemID.WaterWalkingPotion }
        };
    }
}
