using BuffCharm.Items.Small;
using Terraria.ID;
using Terraria.ModLoader;

namespace BuffCharm.Items.Large
{
    class CharmOfApollo : _BaseLargeCharm
    {
        public override string Description => "Grants Ammo Reservation and Archery buffs while equipped";
        public override int[] Buffs => new int[] 
        { 
            BuffID.AmmoReservation, BuffID.Archery
        };
        public override int[,] CharmsCraftedFrom => new int[,]
        {
            { 
                ModContent.ItemType<AmmoReservationCharm>(), 
                ModContent.ItemType<ArcheryCharm>()
            }
        };
    }
}
