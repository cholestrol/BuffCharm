using BuffCharm.Items.Small;
using Terraria.ID;
using Terraria.ModLoader;

namespace BuffCharm.Items.Large
{
    class CharmOfAres : _BaseLargeCharm
    {
        public override string Description => "Grants Ironskin, Endurance, and Titan buffs while equipped";
        public override int[] Buffs => new int[]
        {
            BuffID.Ironskin, BuffID.Endurance, BuffID.Titan
        };
        public override int[,] CharmsCraftedFrom => new int[,]
        {
            {
                ModContent.ItemType<IronskinCharm>(),
                ModContent.ItemType<EnduranceCharm>(),
                ModContent.ItemType<TitanCharm>()
            }
        };
    }
}
