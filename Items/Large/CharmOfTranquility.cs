using BuffCharm.Items.Small;
using Terraria.ID;
using Terraria.ModLoader;

namespace BuffCharm.Items.Large
{
    class CharmOfTranquility : _BaseLargeCharm
    {
        public override string Description => "Grants Builder, Calm, and Mining buffs while equipped";
        public override int[] Buffs => new int[]
        {
            BuffID.Builder, BuffID.Calm, BuffID.Mining
        };
        public override int[,] CharmsCraftedFrom => new int[,]
        {
            {
                ModContent.ItemType<BuilderCharm>(),
                ModContent.ItemType<CalmingCharm>(),
                ModContent.ItemType<MiningCharm>()
            }
        };
    }
}
