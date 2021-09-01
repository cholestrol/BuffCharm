using Terraria.ID;

namespace BuffCharm.Items.Small
{
    class CalmingCharm : _BaseSmallCharm
    {
        public override string Description => "Grants Calm buff while equipped";
        public override int[] Buffs => new int[] { BuffID.Calm };
        public override int[,] PotionsCraftedFrom => new int[,]
        {
            { ItemID.CalmingPotion }
        };
    }
}
