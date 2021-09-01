using Terraria.ID;

namespace BuffCharm.Items.Small
{
    class TitanCharm : _BaseSmallCharm
    {
        public override string Description => "Grants Titan buff while equipped";
        public override int[] Buffs => new int[] { BuffID.Titan };
        public override int[,] PotionsCraftedFrom => new int[,]
        {
            { ItemID.TitanPotion }
        };
    }
}
