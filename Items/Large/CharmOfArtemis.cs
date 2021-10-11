using BuffCharm.Items.Small;
using Terraria.ID;
using Terraria.ModLoader;

namespace BuffCharm.Items.Large
{
    class CharmOfArtemis : _BaseLargeCharm
    {
        public override string Description => "Grants Swiftness and Summoning buffs while equipped";
        public override int[] Buffs => new int[]
        {
            BuffID.Swiftness, BuffID.Summoning
        };
        public override int[,] CharmsCraftedFrom => new int[,]
        {
            {
                ModContent.ItemType<SwiftnessCharm>(),
                ModContent.ItemType<SummoningCharm>()
            }
        };
    }
}
