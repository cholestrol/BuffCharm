using BuffCharm.Items.Small;
using Terraria.ID;
using Terraria.ModLoader;

namespace BuffCharm.Items.Large
{
    class CharmOfLife : _BaseLargeCharm
    {
        public override string Description => "Grants Lifeforce and Regeneration buffs while equipped";
        public override int[] Buffs => new int[]
        {
            BuffID.Lifeforce, BuffID.Regeneration
        };
        public override int[,] CharmsCraftedFrom => new int[,]
        {
            {
                ModContent.ItemType<LifeforceCharm>(),
                ModContent.ItemType<RegenerationCharm>()
            }
        };
    }
}
