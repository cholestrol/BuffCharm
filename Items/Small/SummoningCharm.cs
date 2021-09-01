using Terraria.ID;

namespace BuffCharm.Items.Small
{
    class SummoningCharm : _BaseSmallCharm
    {
        public override string Description => "Grants Summoning buff while equipped";
        public override int[] Buffs => new int[] { BuffID.Summoning };
        public override int[,] PotionsCraftedFrom => new int[,]
        {
            { ItemID.SummoningPotion }
        };
    }
}
