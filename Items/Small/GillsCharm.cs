using Terraria.ID;

namespace BuffCharm.Items.Small
{
    class GillsCharm : _BaseSmallCharm
    {
        public override string Description => "Grants Gills buff while equipped";
        public override int[] Buffs => new int[] { BuffID.Gills };
        public override int[,] PotionsCraftedFrom => new int[,]
        {
            { ItemID.GillsPotion }
        };
    }
}
