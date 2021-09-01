using Terraria.ID;

namespace BuffCharm.Items.Small
{
    class AmmoReservationCharm : _BaseSmallCharm
    {
        public override string Description => "Grants Ammo Reservation buff while equipped";
        public override int[] Buffs => new int[] { BuffID.AmmoReservation };
        public override int[,] PotionsCraftedFrom => new int[,]
        {
            { ItemID.AmmoReservationPotion }
        };
    }
}
