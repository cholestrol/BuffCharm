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
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < PotionsCraftedFrom.GetLength(0); j++)
                {
                    ModRecipe recipe = new ModRecipe(mod);
                    for (int k = 0; k < PotionsCraftedFrom.GetLength(1); k++)
                    {
                        recipe.AddIngredient(PotionsCraftedFrom[j, k], PotionAmountRequired);
                    }
                    switch (i)
                    {
                        case (0):
                            recipe.AddIngredient(ItemID.GoldBar, 6);
                            break;
                        case (1):
                            recipe.AddIngredient(ItemID.PlatinumBar, 6);
                            break;
                        default:
                            break;
                    }
                    recipe.AddTile(TileID.Anvils);
                    recipe.SetResult(this);
                    recipe.AddRecipe();
                }
            }
        }
    }
}
