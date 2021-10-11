using BuffCharm.Items.Small;
using Terraria.ID;
using Terraria.ModLoader;

namespace BuffCharm.Items.Large
{
    class CharmOfTheTurtle : _BaseLargeCharm
    {
        public override string Description => "Grants Endurance and Ironskin buffs while equipped";
        public override int[] Buffs => new int[]
        {
            BuffID.Endurance, BuffID.Ironskin
        };
        public override int[,] CharmsCraftedFrom => new int[,]
        {
            {
                ModContent.ItemType<EnduranceCharm>(),
                ModContent.ItemType<IronskinCharm>()
            }
        };
    }
}
