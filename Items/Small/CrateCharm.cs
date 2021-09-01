using Terraria.ID;

namespace BuffCharm.Items.Small
{
    class CrateCharm : _BaseSmallCharm
    {
        public override string Description => "Grants Crate buff while equipped";
        public override int[] Buffs => new int[] { BuffID.Crate };
        public override int[,] PotionsCraftedFrom => new int[,]
        {
            { ItemID.CratePotion }
        };
    }
}
