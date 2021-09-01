using Terraria.ID;

namespace BuffCharm.Items.Small
{
    class EnduranceCharm : _BaseSmallCharm
    {
        public override string Description => "Grants Endurance buff while equipped";
        public override int[] Buffs => new int[] { BuffID.Endurance };
        public override int[,] PotionsCraftedFrom => new int[,]
        {
            { ItemID.EndurancePotion }
        };
    }
}
