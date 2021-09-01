using Terraria.ID;

namespace BuffCharm.Items.Small
{
    class SonarCharm : _BaseSmallCharm
    {
        public override string Description => "Grants Sonar buff while equipped";
        public override int[] Buffs => new int[] { BuffID.Sonar };
        public override int[,] PotionsCraftedFrom => new int[,]
        {
            { ItemID.SonarPotion }
        };
    }
}
