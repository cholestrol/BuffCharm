using Terraria.ID;

namespace BuffCharm.Items.Small
{
    class MagicPowerCharm : _BaseSmallCharm
    {
        public override string Description => "Grants Magic Power buff while equipped";
        public override int[] Buffs => new int[] { BuffID.MagicPower };
        public override int[,] PotionsCraftedFrom => new int[,]
        {
            { ItemID.MagicPowerPotion }
        };
    }
}
