using Terraria.ID;

namespace BuffCharm.Items.Small
{
    class BattleCharm : _BaseSmallCharm
    {
        public override string Description => "Grants Battle buff while equipped";
        public override int[] Buffs => new int[] { BuffID.Battle };
        public override int[,] PotionsCraftedFrom => new int[,]
        {
            { ItemID.BattlePotion }
        };
    }
}
