using Terraria.ID;

namespace BuffCharm.Items.Small
{
    class BuilderCharm : _BaseSmallCharm
    {
        public override string Description => "Grants Builder buff while equipped";
        public override int[] Buffs => new int[] { BuffID.Builder };
        public override int[,] PotionsCraftedFrom => new int[,]
        {
            { ItemID.BuilderPotion }
        };
    }
}
