using BuffCharm.Items.Small;
using Terraria.ID;
using Terraria.ModLoader;

namespace BuffCharm.Items.Large
{
    class CharmOfTheDwarf : _BaseLargeCharm
    {
        public override string Description => "Grants Builder, Dangersense, Mining, and Spelunker buffs while equipped";
        public override int[] Buffs => new int[]
        {
            BuffID.Builder, BuffID.Dangersense, BuffID.Mining, BuffID.Spelunker
        };
        public override int[,] CharmsCraftedFrom => new int[,]
        {
            {
                ModContent.ItemType<BuilderCharm>(),
                ModContent.ItemType<DangersenseCharm>(),
                ModContent.ItemType<MiningCharm>(),
                ModContent.ItemType<SpelunkerCharm>()
            }
        };
    }
}
