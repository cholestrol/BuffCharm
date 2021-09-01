using Terraria.ID;

namespace BuffCharm.Items.Small
{
    class RegenerationCharm : _BaseSmallCharm
    {
        public override string Description => "Grants Regeneration buff while equipped";
        public override int[] Buffs => new int[] { BuffID.Regeneration };
        public override int[,] PotionsCraftedFrom => new int[,]
        {
            { ItemID.RegenerationPotion }
        };
    }
}
