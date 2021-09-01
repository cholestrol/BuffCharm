using Terraria.ID;
using Terraria.ModLoader;

namespace BuffCharm
{
    class BuffCharmItem : GlobalItem
    {
        public override void AddRecipes()
        {
            ModRecipe heartreachPotion = new ModRecipe(mod);
            heartreachPotion.AddIngredient(ItemID.BottledWater);
            heartreachPotion.AddIngredient(ItemID.PrincessFish);
            heartreachPotion.AddIngredient(ItemID.Daybloom);
            heartreachPotion.AddTile(TileID.Bottles);
            heartreachPotion.alchemy = true;
            heartreachPotion.SetResult(ItemID.HeartreachPotion);
            heartreachPotion.AddRecipe();
        }
    }
}
