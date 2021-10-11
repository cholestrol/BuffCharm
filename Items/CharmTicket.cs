using Terraria.ModLoader;

namespace BuffCharm.Items
{
    class CharmTicket : ModItem
    {
        public static readonly int OneGold = 50000;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Charm Ticket");
            Tooltip.SetDefault("Can be crafted into a charm or sold");
        }
        public override void SetDefaults()
        {
            item.maxStack = 1;
            item.value = OneGold * 50;
        }
    }
}
