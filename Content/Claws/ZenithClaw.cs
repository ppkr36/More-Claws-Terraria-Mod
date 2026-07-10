using ClawProgression.Common.Systems;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace ClawProgression.Content.Claws
{
    public class ZenithClaw : ModItem
    {
        public override void SetDefaults()
        {
            Item.DamageType = DamageClass.Melee;
            Item.useTime = 2;
            Item.useAnimation = 7;
            Item.damage = 42;
            Item.pick = 250;
            Item.width = 46;
            Item.height = 46;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.axe = 25;
            Item.tileBoost = 8;
            Item.UseSound = SoundID.Item1;
            Item.value = Item.sellPrice(gold: 2);
            Item.rare = ItemRarityID.Red;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddRecipeGroup(ClawRecipeGroupSystem.CopperTinClaws);
            recipe.AddRecipeGroup(ClawRecipeGroupSystem.IronLeadClaws);
            recipe.AddRecipeGroup(ClawRecipeGroupSystem.SilverTungstenClaws);
            recipe.AddRecipeGroup(ClawRecipeGroupSystem.GoldPlatinumClaws);
            recipe.AddRecipeGroup(ClawRecipeGroupSystem.DemoniteCrimtaneClaws);
            recipe.AddRecipeGroup(ClawRecipeGroupSystem.CobaltPalladiumClaws);
            recipe.AddRecipeGroup(ClawRecipeGroupSystem.MythrilOrichalcumClaws);
            recipe.AddRecipeGroup(ClawRecipeGroupSystem.AdamantiteTitaniumClaws);
            recipe.AddIngredient(ItemID.ShroomiteDiggingClaw);
            recipe.AddIngredient(ItemID.LunarBar, 10);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.Register();
        }
    }
}