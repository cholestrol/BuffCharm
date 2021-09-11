using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace BuffCharm
{
    class BuffCharmNPC : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type == NPCID.Wizard)
            {
                shop.item[nextSlot].SetDefaults(ItemID.HolyWater);
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ItemID.UnholyWater);
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ItemID.BloodWater);
                nextSlot++;
            }
        }
    }
}
