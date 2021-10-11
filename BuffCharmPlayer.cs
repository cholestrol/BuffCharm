using BuffCharm.Buffs;
using BuffCharm.UI;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace BuffCharm
{
    class BuffCharmPlayer : ModPlayer
    {
        private const int NumCoinSlots = 4;
        public List<int> BuffsFromCharms = new List<int>();
        private List<Item> Charms = new List<Item>();
        public List<int> DisabledBuffs = new List<int>();
        public bool justSpawned = false;
        public List<Item> CachedDeleteItems = new List<Item>();

        public override TagCompound Save()
        {
            Charms = new List<Item>();
            foreach (CustomItemSlot slot in BuffCharm.ModInstance.CharmUIInstance.CharmSlots)
            {
                Charms.Add(slot.Item);
            }
            return new TagCompound
            {
                {"charms", Charms},
                {"disabledbuffs", DisabledBuffs}
            };
        }

        public override void Load(TagCompound tag)
        {
            Charms = tag.Get<List<Item>>("charms");
            DisabledBuffs = tag.Get<List<int>>("disabledbuffs");
        }

        public override void OnEnterWorld(Player player)
        {
            List<CustomItemSlot> charmSlots = BuffCharm.ModInstance.CharmUIInstance.CharmSlots;
            if (Charms.Count != 0)
            {
                for (int i = 0; i < charmSlots.Count; i++)
                {
                    charmSlots[i].Item = Charms[i];
                }
            }
        }

        public override void OnRespawn(Player player)
        {
            justSpawned = true;
        }

        public override void UpdateEquips(ref bool wallSpeedBuff, ref bool tileSpeedBuff, ref bool tileRangeBuff)
        {
            if (!Main.dedServ)
            {
                if (!justSpawned)
                {
                    if (DisabledBuffs.Count > 0 && !player.HasBuff(ModContent.BuffType<DisabledBuffs>()))
                    {
                        DisabledBuffs = new List<int>();
                    }
                    else
                    {
                        foreach (int buff in BuffsFromCharms)
                        {
                            if (player.HasBuff(buff))
                            {
                                player.ClearBuff(buff);
                            }
                            else if (!DisabledBuffs.Contains(buff))
                            {
                                DisabledBuffs.Add(buff);
                            }
                            Main.buffNoTimeDisplay[buff] = false;
                        }
                    }
                }
                player.GetModPlayer<BuffCharmPlayer>().BuffsFromCharms = new List<int>();
                for (int i = 0; i < BuffCharm.ModInstance.CharmUIInstance.CharmSlots.Count; i++)
                {
                    player.VanillaUpdateEquip(BuffCharm.ModInstance.CharmUIInstance.CharmSlots[i].Item);
                }
                if (DisabledBuffs.Count > 0)
                {
                    player.AddBuff(ModContent.BuffType<DisabledBuffs>(), 120);
                }
                else
                {
                    player.ClearBuff(ModContent.BuffType<DisabledBuffs>());
                }
                justSpawned = false;
            }
        }

        public override bool ShiftClickSlot(Item[] inventory, int context, int slot)
        {
            if (!Main.dedServ)
            {
                bool inCharmSlots = false;
                foreach (CustomItemSlot customSlot in BuffCharm.ModInstance.CharmUIInstance.CharmSlots)
                {
                    if (customSlot.Item == inventory[slot])
                    {
                        inCharmSlots = true;
                        break;
                    }
                }
                if (inCharmSlots)
                {
                    for (int i = player.inventory.Length - BuffCharm.ModInstance.CharmUIInstance.CharmSlots.Count - NumCoinSlots - 1; i >= 0; i--)
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
            }
            return false;
        }

        public override void PostUpdate()
        {
            if (CachedDeleteItems.Count > 0)
            {
                foreach (Item item in player.inventory)
                {
                    if (CachedDeleteItems.Contains(item))
                    {
                        item.TurnToAir();
                    }
                }
                CachedDeleteItems = new List<Item>();
            }
        }
    }
}
