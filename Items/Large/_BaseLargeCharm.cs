using Terraria.ID;
using Terraria.ModLoader;

namespace BuffCharm.Items.Large
{
    public abstract class _BaseLargeCharm : _BaseBuffCharm
    {
        public abstract int[,] CharmsCraftedFrom { get; }
        public override int Gold => 5;
        public override int Rarity => ItemRarityID.Orange;
        public override bool CanBeCraftedFromTicket => true;
        public override void AddRecipes()
        {
            for (int i = 0; i < CharmsCraftedFrom.GetLength(0); i++)
            {
                ModRecipe recipe = new ModRecipe(mod);
                for (int j = 0; j < CharmsCraftedFrom.GetLength(1); j++)
                {
                    recipe.AddIngredient(CharmsCraftedFrom[i, j], 1);
                }
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
            if (CanBeCraftedFromTicket)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ModContent.ItemType<CharmTicket>(), 1);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }
}
