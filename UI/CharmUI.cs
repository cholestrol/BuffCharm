using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.UI;

namespace BuffCharm.UI
{
    public class CharmUI : UIState
    {
        public static readonly int SlotCount = 5;
        public static readonly int LeftPositionStart = 20;
        public static readonly int LeftPositionOffset = 48;
        public static readonly int TopPosition = 258;
        public static readonly float SlotScale = 0.85f;

        public List<CustomItemSlot> CharmSlots = new List<CustomItemSlot>();
        public bool Visible => Main.playerInventory
                            && ((Main.ActivePlayersCount == 1 && Main.player[0].chest == -1) || (Main.ActivePlayersCount > 1 && Main.clientPlayer.chest == -1))
                            && Main.npcShop == 0;
        public override void OnInitialize()
        {
            CroppedTexture2D emptyTexture = new CroppedTexture2D(
                ModContent.GetInstance<BuffCharm>().GetTexture("UI/CharmSlotBackground"),
                CustomItemSlot.DefaultColors.EmptyTexture);
            CroppedTexture2D backgroundTexture = new CroppedTexture2D(
                ModContent.GetInstance<BuffCharm>().GetTexture("UI/BackgroundTexture"));
            for (int i = 0; i < SlotCount; i++)
            {
                CustomItemSlot slotRef = new CustomItemSlot(ItemSlot.Context.InventoryItem, SlotScale)
                {
                    IsValidItem = item => BuffCharm.Charms.Contains(item.type),
                    EmptyTexture = emptyTexture,
                    BackgroundTexture = backgroundTexture,
                    HoverText = "Charm",
                };
                slotRef.Left.Set(LeftPositionStart + (LeftPositionOffset * i), 0);
                slotRef.Top.Set(TopPosition, 0);
                Append(slotRef);
                CharmSlots.Add(slotRef);
            }
        }
    }
}
