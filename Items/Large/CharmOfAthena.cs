using BuffCharm.Items.Small;
using Terraria.ID;
using Terraria.ModLoader;

namespace BuffCharm.Items.Large
{
    class CharmOfAthena : _BaseLargeCharm
    {
        public override string Description => "Grants Magic Power, Mana Regeneration, and Regeneration buffs while equipped";
        public override int[] Buffs => new int[]
        {
            BuffID.MagicPower, BuffID.ManaRegeneration, BuffID.Regeneration
        };
        public override int[,] CharmsCraftedFrom => new int[,]
        {
            {
                ModContent.ItemType<MagicPowerCharm>(),
                ModContent.ItemType<ManaRegenerationCharm>(),
                ModContent.ItemType<RegenerationCharm>()
            }
        };
    }
}
