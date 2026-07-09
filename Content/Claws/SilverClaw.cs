using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace ClawProgression.Content.Claws
{
    public class SilverClaw : ModItem
    {
        public override void SetDefaults()
        {
            Item.DamageType = DamageClass.Melee;
            Item.useTime = 10;
            Item.useAnimation = 12;
            Item.damage = 3;
            Item.pick = 50;
            Item.width = 32;
            Item.height = 32;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.axe = 8;
            Item.tileBoost = -2;
            Item.UseSound = SoundID.Item1;
            Item.value = Item.sellPrice(silver: 10);
            Item.rare = ItemRarityID.White;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.SilverBar, 6);
            recipe.AddRecipeGroup(RecipeGroupID.Wood, 12);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}
