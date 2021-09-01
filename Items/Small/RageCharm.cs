using Terraria.ID;

namespace BuffCharm.Items.Small
{
    class RageCharm : _BaseSmallCharm
    {
        public override string Description => "Grants Rage buff while equipped";
        public override int[] Buffs => new int[] { BuffID.Rage };
        public override int[,] PotionsCraftedFrom => new int[,]
        {
            { ItemID.RagePotion }
        };
    }
}
