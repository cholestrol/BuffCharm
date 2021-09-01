using Terraria.ID;

namespace BuffCharm.Items.Small
{
    class LifeforceCharm : _BaseSmallCharm
    {
        public override string Description => "Grants Lifeforce buff while equipped";
        public override int[] Buffs => new int[] { BuffID.Lifeforce };
        public override int[,] PotionsCraftedFrom => new int[,]
        {
            { ItemID.LifeforcePotion }
        };
    }
}
