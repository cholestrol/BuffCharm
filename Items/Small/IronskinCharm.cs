using Terraria.ID;

namespace BuffCharm.Items.Small
{
    class IronskinCharm : _BaseSmallCharm
    {
        public override string Description => "Grants Ironskin buff while equipped";
        public override int[] Buffs => new int[] { BuffID.Ironskin };
        public override int[,] PotionsCraftedFrom => new int[,]
        {
            { ItemID.IronskinPotion }
        };
    }
}
