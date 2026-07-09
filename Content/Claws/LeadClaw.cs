using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace ClawProgression.Content.Claws
{
    public class LeadClaw : ModItem
    {
        public override void SetDefaults()
        {
            Item.DamageType = DamageClass.Melee;
            Item.useTime = 9;
            Item.useAnimation = 12;
            Item.damage = 3;
            Item.pick = 40;
            Item.width = 32;
            Item.height = 32;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.axe = 5;
            Item.tileBoost = -2;
            Item.UseSound = SoundID.Item1;
            Item.value = Item.sellPrice(copper: 85);
            Item.rare = ItemRarityID.White;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.LeadBar, 6);
            recipe.AddRecipeGroup(RecipeGroupID.Wood, 12);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}
