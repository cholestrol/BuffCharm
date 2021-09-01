using BuffCharm.Items.Small;
using Terraria.ID;
using Terraria.ModLoader;

namespace BuffCharm.Items.Large
{
    class CharmOfSight : _BaseLargeCharm
    {
        public override string Description => "Grants Hunter, Night Owl, and Shine buffs while equipped";
        public override int[] Buffs => new int[]
        {
            BuffID.Hunter, BuffID.NightOwl, BuffID.Shine
        };
        public override int[,] CharmsCraftedFrom => new int[,]
        {
            {
                ModContent.ItemType<HunterCharm>(),
                ModContent.ItemType<NightOwlCharm>(),
                ModContent.ItemType<ShineCharm>()
            }
        };
    }
}
