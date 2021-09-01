using BuffCharm.Items.Small;
using Terraria.ID;
using Terraria.ModLoader;

namespace BuffCharm.Items.Large
{
    class CharmOfApollo : _BaseLargeCharm
    {
        public override string Description => "Grants Ammo Reservation, Archery, and Night Owl buffs while equipped";
        public override int[] Buffs => new int[] 
        { 
            BuffID.AmmoReservation, BuffID.Archery, BuffID.NightOwl
        };
        public override int[,] CharmsCraftedFrom => new int[,]
        {
            { 
                ModContent.ItemType<AmmoReservationCharm>(), 
                ModContent.ItemType<ArcheryCharm>(), 
                ModContent.ItemType<NightOwlCharm>()
            }
        };
    }
}
