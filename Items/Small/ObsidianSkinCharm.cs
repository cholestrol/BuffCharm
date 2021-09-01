using Terraria.ID;

namespace BuffCharm.Items.Small
{
    class ObsidianSkinCharm : _BaseSmallCharm
    {
        public override string Description => "Grants Obsidian Skin buff while equipped";
        public override int[] Buffs => new int[] { BuffID.ObsidianSkin };
        public override int[,] PotionsCraftedFrom => new int[,]
        {
            { ItemID.ObsidianSkinPotion }
        };
    }
}
