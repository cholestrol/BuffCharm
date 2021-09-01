using Terraria.ID;

namespace BuffCharm.Items.Small
{
    class DangersenseCharm : _BaseSmallCharm
    {
        public override string Description => "Grants Dangersense buff while equipped";
        public override int[] Buffs => new int[] { BuffID.Dangersense };
        public override int[,] PotionsCraftedFrom => new int[,]
        {
            { ItemID.TrapsightPotion }
        };
    }
}
