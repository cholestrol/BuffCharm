using BuffCharm.Items.Small;
using Terraria.ID;
using Terraria.ModLoader;

namespace BuffCharm.Items.Large
{
    class CharmOfFury : _BaseLargeCharm
    {
        public override string Description => "Grants Rage, Swiftness, and Wrath buffs while equipped";
        public override int[] Buffs => new int[]
        {
            BuffID.Rage, BuffID.Swiftness, BuffID.Wrath
        };
        public override int[,] CharmsCraftedFrom => new int[,]
        {
            {
                ModContent.ItemType<RageCharm>(),
                ModContent.ItemType<SwiftnessCharm>(),
                ModContent.ItemType<WrathCharm>()
            }
        };
    }
}
