using Terraria.ID;

namespace BuffCharm.Items.Small
{
    class ManaRegenerationCharm : _BaseSmallCharm
    {
        public override string Description => "Grants Mana Regeneration buff while equipped";
        public override int[] Buffs => new int[] { BuffID.ManaRegeneration };
        public override int[,] PotionsCraftedFrom => new int[,]
        {
            { ItemID.ManaRegenerationPotion }
        };
    }
}
