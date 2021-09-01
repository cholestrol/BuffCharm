using Terraria.ID;

namespace BuffCharm.Items.Small
{
    class NightOwlCharm : _BaseSmallCharm
    {
        public override string Description => "Grants Night Owl buff while equipped";
        public override int[] Buffs => new int[] { BuffID.NightOwl };
        public override int[,] PotionsCraftedFrom => new int[,]
        {
            { ItemID.NightOwlPotion }
        };
    }
}
