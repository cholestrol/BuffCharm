using BuffCharm.Items.Small;
using Terraria.ID;
using Terraria.ModLoader;

namespace BuffCharm.Items.Large
{
    class CharmOfTheAngler : _BaseLargeCharm
    {
        public override string Description => "Grants Crate, Fishing, and Sonar buffs while equipped";
        public override int[] Buffs => new int[]
        {
            BuffID.Crate, BuffID.Fishing, BuffID.Sonar
        };
        public override int[,] CharmsCraftedFrom => new int[,]
        {
            {
                ModContent.ItemType<CrateCharm>(),
                ModContent.ItemType<FishingCharm>(),
                ModContent.ItemType<SonarCharm>()
            }
        };
    }
}
