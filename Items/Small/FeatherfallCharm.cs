using Terraria.ID;

namespace BuffCharm.Items.Small
{
    class FeatherfallCharm : _BaseSmallCharm
    {
        public override string Description => "Grants Featherfall buff while equipped";
        public override int[] Buffs => new int[] { BuffID.Featherfall };
        public override int[,] PotionsCraftedFrom => new int[,]
        {
            { ItemID.FeatherfallPotion }
        };
    }
}
