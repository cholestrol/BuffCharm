using Terraria.ID;

namespace BuffCharm.Items.Small
{
    class GravitationCharm : _BaseSmallCharm
    {
        public override string Description => "Grants Gravitation buff while equipped";
        public override int[] Buffs => new int[] { BuffID.Gravitation };
        public override int[,] PotionsCraftedFrom => new int[,]
        {
            { ItemID.GravitationPotion }
        };
    }
}
