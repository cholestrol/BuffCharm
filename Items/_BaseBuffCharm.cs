using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using System.Collections.Generic;
using BuffCharm.UI;
using BuffCharm.Buffs;

namespace BuffCharm.Items
{
    public abstract class _BaseBuffCharm : ModItem
    {
        public static readonly int BuffTime = 120;
        public static readonly int OneGold = 50000;
        public abstract string Description { get; }
        public abstract int Gold { get; }
        public abstract int Rarity { get; }
        public abstract int[] Buffs { get; }

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault(Description);
            BuffCharm.Charms.Add(item.type);
        }

        public override void SetDefaults()
        {
            item.maxStack = 1;
            item.value = OneGold * Gold;
            item.rare = Rarity;
        }

        public override void UpdateEquip(Player player)
        {
            foreach (int buff in Buffs)
            {
                Main.buffNoTimeDisplay[buff] = true;
                //if (!player.GetModPlayer<BuffCharmPlayer>().DisabledBuffs.Contains(buff))
                {
                    player.AddBuff(buff, BuffTime);
                }
                player.GetModPlayer<BuffCharmPlayer>().BuffsFromCharms.Add(buff);
            }
        }

        public override bool CanRightClick()
        {
            List<CustomItemSlot> charmSlotRef = BuffCharm.ModInstance.CharmUIInstance.CharmSlots;
            foreach (CustomItemSlot slot in charmSlotRef)
            {
                if (slot.Item == item)
                {
                    return false;
                }
            }
            foreach (CustomItemSlot slot in charmSlotRef)
            {
                if (slot.Item.IsAir)
                {
                    return true;
                }
            }
            return false;
        }

        public override void RightClick(Player player)
        {
            List<CustomItemSlot> charmSlotRef = BuffCharm.ModInstance.CharmUIInstance.CharmSlots;
            foreach (CustomItemSlot slot in charmSlotRef)
            {
                if (slot.Item.IsAir)
                {
                    slot.Item = item.Clone();
                    Main.PlaySound(SoundID.Grab);
                    break;
                }
            }
        }
    }
}
