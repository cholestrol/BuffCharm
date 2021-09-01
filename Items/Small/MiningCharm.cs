using Terraria.ID;

namespace BuffCharm.Items.Small
{
    class MiningCharm : _BaseSmallCharm
    {
        public override string Description => "Grants Mining buff while equipped";
        public override int[] Buffs => new int[] { BuffID.Mining };
        public override int[,] PotionsCraftedFrom => new int[,]
        {
            { ItemID.MiningPotion }
        };
    }
}
