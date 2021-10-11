using BuffCharm.Items.Small;
using Terraria.ID;
using Terraria.ModLoader;

namespace BuffCharm.Items.Large
{
    class CharmOfTheCorruption : _BaseLargeCharm
    {
        public override string Description => "Grants Thorns and Wrath buffs while equipped";
        public override int[] Buffs => new int[]
        {
            BuffID.Thorns, BuffID.Wrath
        };
        public override int[,] CharmsCraftedFrom => new int[,]
        {
            {
                ModContent.ItemType<ThornsCharm>(),
                ModContent.ItemType<WrathCharm>()
            }
        };
    }
}
