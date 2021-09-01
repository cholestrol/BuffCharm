using BuffCharm.Items.Small;
using Terraria.ID;
using Terraria.ModLoader;

namespace BuffCharm.Items.Large
{
    class CharmOfChaos : _BaseLargeCharm
    {
        public override string Description => "Grants Battle, Rage, and Wrath buffs while equipped";
        public override int[] Buffs => new int[]
        {
            BuffID.Battle, BuffID.Rage, BuffID.Wrath
        };
        public override int[,] CharmsCraftedFrom => new int[,]
        {
            {
                ModContent.ItemType<BattleCharm>(),
                ModContent.ItemType<RageCharm>(),
                ModContent.ItemType<WrathCharm>()
            }
        };
    }
}
