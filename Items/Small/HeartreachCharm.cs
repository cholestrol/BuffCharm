using Terraria.ID;

namespace BuffCharm.Items.Small
{
    class HeartreachCharm : _BaseSmallCharm
    {
        public override string Description => "Grants Heartreach buff while equipped";
        public override int[] Buffs => new int[] { BuffID.Heartreach };
        public override int[,] PotionsCraftedFrom => new int[,]
        {
            { ItemID.HeartreachPotion }
        };
    }
}
