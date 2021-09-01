using Terraria.ID;

namespace BuffCharm.Items.Small
{
    class WrathCharm : _BaseSmallCharm
    {
        public override string Description => "Grants Wrath buff while equipped";
        public override int[] Buffs => new int[] { BuffID.Wrath };
        public override int[,] PotionsCraftedFrom => new int[,]
        {
            { ItemID.WrathPotion }
        };
    }
}
