using Terraria.ID;

namespace BuffCharm.Items.Small
{
    class HunterCharm : _BaseSmallCharm
    {
        public override string Description => "Grants Hunter buff while equipped";
        public override int[] Buffs => new int[] { BuffID.Hunter };
        public override int[,] PotionsCraftedFrom => new int[,]
        {
            { ItemID.HunterPotion }
        };
    }
}
