using BuffCharm.Items.Small;
using Terraria.ID;
using Terraria.ModLoader;

namespace BuffCharm.Items.Large
{
    class CharmOfTheUnderworld : _BaseLargeCharm
    {
        public override string Description => "Grants Inferno, Obsidian Skin, and Warmth buffs while equipped";
        public override int[] Buffs => new int[]
        {
            BuffID.Inferno, BuffID.ObsidianSkin, BuffID.Warmth
        };
        public override int[,] CharmsCraftedFrom => new int[,]
        {
            {
                ModContent.ItemType<InfernoCharm>(),
                ModContent.ItemType<ObsidianSkinCharm>(),
                ModContent.ItemType<WarmthCharm>()
            }
        };
    }
}
