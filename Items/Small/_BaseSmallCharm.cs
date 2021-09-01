using Terraria.ID;
using Terraria.ModLoader;

namespace BuffCharm.Items.Small
{
    public abstract class _BaseSmallCharm : _BaseBuffCharm
    {
        public static readonly int PotionAmountRequired = 10;
        public abstract int[,] PotionsCraftedFrom { get; }
        public override int Gold => 1;
        public override int Rarity => ItemRarityID.Green;
        public override void AddRecipes()
        {
            for (int i = 0; i < PotionsCraftedFrom.GetLength(0); i++)
            {
                ModRecipe recipe = new ModRecipe(mod);
                for (int j = 0; j < PotionsCraftedFrom.GetLength(1); j++)
                {
                    recipe.AddIngredient(PotionsCraftedFrom[i, j], PotionAmountRequired);
                }
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }
}
