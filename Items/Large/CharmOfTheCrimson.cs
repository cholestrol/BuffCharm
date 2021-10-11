using BuffCharm.Items.Small;
using Terraria.ID;
using Terraria.ModLoader;

namespace BuffCharm.Items.Large
{
    class CharmOfTheCrimson : _BaseLargeCharm
    {
        public override string Description => "Grants Rage and Heartreach buffs while equipped";
        public override int[] Buffs => new int[]
        {
            BuffID.Rage, BuffID.Heartreach
        };
        public override int[,] CharmsCraftedFrom => new int[,]
        {
            {
                ModContent.ItemType<RageCharm>(),
                ModContent.ItemType<HeartreachCharm>()
            }
        };
    }
}
