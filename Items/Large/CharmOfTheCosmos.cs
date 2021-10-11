using BuffCharm.Items.Small;
using Terraria.ID;
using Terraria.ModLoader;

namespace BuffCharm.Items.Large
{
    class CharmOfTheCosmos : _BaseLargeCharm
    {
        public override string Description => "Grants Featherfall and Gravitation buffs while equipped";
        public override int[] Buffs => new int[] 
        { 
            BuffID.Featherfall, BuffID.Gravitation
        };
        public override int[,] CharmsCraftedFrom => new int[,]
        {
            { 
                ModContent.ItemType<FeatherfallCharm>(), 
                ModContent.ItemType<GravitationCharm>()
            }
        };
    }
}
