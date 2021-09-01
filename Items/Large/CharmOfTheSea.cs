using BuffCharm.Items.Small;
using Terraria.ID;
using Terraria.ModLoader;

namespace BuffCharm.Items.Large
{
    class CharmOfTheSea : _BaseLargeCharm
    {
        public override string Description => "Grants Flipper, Gills, and Water Walking buffs while equipped";
        public override int[] Buffs => new int[]
        {
            BuffID.Flipper, BuffID.Gills, BuffID.WaterWalking
        };
        public override int[,] CharmsCraftedFrom => new int[,]
        {
            {
                ModContent.ItemType<FlipperCharm>(),
                ModContent.ItemType<GillsCharm>(),
                ModContent.ItemType<WaterWalkingCharm>()
            }
        };
    }
}
