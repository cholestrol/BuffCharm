using BuffCharm.Items.Small;
using Terraria.ID;
using Terraria.ModLoader;

namespace BuffCharm.Items.Large
{
    class CharmOfAres : _BaseLargeCharm
    {
        public override string Description => "Grants Titan and Warmth buffs while equipped";
        public override int[] Buffs => new int[]
        {
            BuffID.Titan, BuffID.Warmth
        };
        public override int[,] CharmsCraftedFrom => new int[,]
        {
            {
                ModContent.ItemType<TitanCharm>(),
                ModContent.ItemType<WarmthCharm>()
            }
        };
    }
}
