using Terraria.ID;

namespace BuffCharm.Items.Small
{
    class ShineCharm : _BaseSmallCharm
    {
        public override string Description => "Grants Shine buff while equipped";
        public override int[] Buffs => new int[] { BuffID.Shine };
        public override int[,] PotionsCraftedFrom => new int[,]
        {
            { ItemID.ShinePotion }
        };
    }
}
