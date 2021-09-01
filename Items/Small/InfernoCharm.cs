using Terraria.ID;

namespace BuffCharm.Items.Small
{
    class InfernoCharm : _BaseSmallCharm
    {
        public override string Description => "Grants Inferno buff while equipped";
        public override int[] Buffs => new int[] { BuffID.Inferno };
        public override int[,] PotionsCraftedFrom => new int[,]
        {
            { ItemID.InfernoPotion }
        };
    }
}
