using BuffCharm.Items.Small;
using Terraria.ID;
using Terraria.ModLoader;

namespace BuffCharm.Items.Large
{
    class CharmOfTheTurtle : _BaseLargeCharm
    {
        public override string Description => "Grants Endurance, Ironskin, and Thorns buffs while equipped";
        public override int[] Buffs => new int[]
        {
            BuffID.Endurance, BuffID.Ironskin, BuffID.Thorns
        };
        public override int[,] CharmsCraftedFrom => new int[,]
        {
            {
                ModContent.ItemType<EnduranceCharm>(),
                ModContent.ItemType<IronskinCharm>(),
                ModContent.ItemType<ThornsCharm>()
            }
        };
    }
}
