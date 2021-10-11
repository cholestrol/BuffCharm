using Terraria;
using Terraria.ModLoader;

namespace BuffCharm.Items
{
    abstract class DeprecatedCharm : ModItem 
    { 
        public override string Texture => "BuffCharm/Items/DeprecatedCharm";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Deprecated Charm");
            Tooltip.SetDefault("This charm has been deprecated\nPlace this in your inventory to recieve a Charm Ticket");
        }
        public override void SetDefaults()
        {
            item.maxStack = 1;
        }
        public override void UpdateInventory(Player player)
        {
            player.PutItemInInventory(ModContent.ItemType<CharmTicket>());
            player.GetModPlayer<BuffCharmPlayer>().CachedDeleteItems.Add(item);
        }
    }
}
