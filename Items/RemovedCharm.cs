using Terraria;
using Terraria.ModLoader;

namespace BuffCharm.Items
{
    abstract class RemovedCharm : ModItem 
    { 
        public override string Texture => "BuffCharm/Items/RemovedCharm";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Removed Charm");
            Tooltip.SetDefault("This charm has been removed\nPlace this in your inventory to recieve a Charm Ticket");
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
