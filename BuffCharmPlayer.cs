using BuffCharm.UI;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace BuffCharm
{
    class BuffCharmPlayer : ModPlayer
    {
        private static List<CustomItemSlot> GetCharmSlots => BuffCharm.ModInstance.CharmUIInstance.CharmSlots;

        public override TagCompound Save()
        {
            TagCompound tagCompound = new TagCompound();
            for (int i = 0; i < GetCharmSlots.Count; i++)
            {
                tagCompound.Add(new KeyValuePair<string, object>("charm" + i, ItemIO.Save(GetCharmSlots[i].Item)));
            }
            return tagCompound;
        }

        public override void Load(TagCompound tag)
        {
            for (int i = 0; i < GetCharmSlots.Count; i++)
            {
                GetCharmSlots[i].Item = ItemIO.Load(tag.GetCompound("charm" + i));
            }
        }

        public override void UpdateEquips(ref bool wallSpeedBuff, ref bool tileSpeedBuff, ref bool tileRangeBuff)
        {
            for (int i = 0; i < GetCharmSlots.Count; i++)
            {
                player.VanillaUpdateEquip(GetCharmSlots[i].Item);
            }
        }

        public override bool ShiftClickSlot(Item[] inventory, int context, int slot)
        {
            bool inCharmSlots = false;
            foreach (CustomItemSlot customSlot in GetCharmSlots)
            {
                if (customSlot.Item == inventory[slot])
                {
                    inCharmSlots = true;
                    break;
                }
            }
            if (inCharmSlots)
            {
                for (int i = player.inventory.Length - GetCharmSlots.Count - 1; i >= 0; i--)
                {
                    if (player.inventory[i].IsAir)
                    {
                        player.inventory[i] = inventory[slot].Clone();
                        inventory[slot].TurnToAir();
                        Main.PlaySound(SoundID.Grab);
                        return true;
                    }
                }
                return true;
            }
            return false;
        }
    }
}
