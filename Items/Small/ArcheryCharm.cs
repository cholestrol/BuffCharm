using Terraria.ID;

namespace BuffCharm.Items.Small
{
    class ArcheryCharm : _BaseSmallCharm
    {
        public override string Description => "Grants Archery buff while equipped";
        public override int[] Buffs => new int[] { BuffID.Archery };
        public override int[,] PotionsCraftedFrom => new int[,]
        {
            { ItemID.ArcheryPotion }
        };
    }
}
