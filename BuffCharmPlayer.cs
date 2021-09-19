using BuffCharm.UI;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.UI.Chat;

namespace BuffCharm
{
    class BuffCharmPlayer : ModPlayer
    {
        public override bool CloneNewInstances => true;

        private const int NumCoinSlots = 4;

        public List<int> BuffsFromCharms = new List<int>();
        private List<CustomItemSlot> GetCharmSlots => BuffCharm.ModInstance.CharmUIInstance.CharmSlots;
        private List<Item> Charms;

        public override TagCompound Save()
        {
            Charms = new List<Item>();
            foreach (CustomItemSlot slot in GetCharmSlots)
            {
                Charms.Add(slot.Item);
            }
            return new TagCompound
            {
                {"charms", Charms}
            };
        }

        public override void Load(TagCompound tag)
        {
            Charms = tag.Get<List<Item>>("charms");
        }

        public override void OnEnterWorld(Player player)
        {
            for (int i = 0; i < GetCharmSlots.Count; i++)
            {
                GetCharmSlots[i].Item = Charms[i];
            }
        }

        public override void UpdateEquips(ref bool wallSpeedBuff, ref bool tileSpeedBuff, ref bool tileRangeBuff)
        {
            foreach (int buff in BuffsFromCharms)
            {
                player.ClearBuff(buff);
                Main.buffNoTimeDisplay[buff] = false;
            }
            BuffsFromCharms = new List<int>();
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
                for (int i = player.inventory.Length - GetCharmSlots.Count - NumCoinSlots - 1; i >= 0; i--)
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
