using Terraria.ID;

namespace BuffCharm.Items.Small
{
    class FishingCharm : _BaseSmallCharm
    {
        public override string Description => "Grants Fishing buff while equipped";
        public override int[] Buffs => new int[] { BuffID.Fishing };
        public override int[,] PotionsCraftedFrom => new int[,]
        {
            { ItemID.FishingPotion }
        };
    }
}
