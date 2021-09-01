using Terraria.ID;

namespace BuffCharm.Items.Small
{
    class ThornsCharm : _BaseSmallCharm
    {
        public override string Description => "Grants Thorns buff while equipped";
        public override int[] Buffs => new int[] { BuffID.Thorns };
        public override int[,] PotionsCraftedFrom => new int[,]
        {
            { ItemID.ThornsPotion }
        };
    }
}
