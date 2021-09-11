using BuffCharm.Items.Small;
using Terraria.ID;
using Terraria.ModLoader;

namespace BuffCharm.Items.Large
{
    class CharmOfTheCosmos : _BaseLargeCharm
    {
        public override string Description => "Grants Featherfall, Gravitation, and Shine buffs while equipped";
        public override int[] Buffs => new int[] 
        { 
            BuffID.Featherfall, BuffID.Gravitation, BuffID.Shine
        };
        public override int[,] CharmsCraftedFrom => new int[,]
        {
            { 
                ModContent.ItemType<FeatherfallCharm>(), 
                ModContent.ItemType<GravitationCharm>(), 
                ModContent.ItemType<ShineCharm>()
            }
        };
    }
}
