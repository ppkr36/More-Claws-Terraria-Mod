using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace ClawProgression.Content.Claws
{
    public class DeathbringerClaw : ModItem
    {
        public override void SetDefaults()
        {
            Item.DamageType = DamageClass.Melee;
            Item.useTime = 10;
            Item.useAnimation = 12;
            Item.damage = 3;
            Item.pick = 65;
            Item.width = 32;
            Item.height = 32;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.axe = 10;
            Item.tileBoost = -2;
            Item.UseSound = SoundID.Item1;
            Item.value = Item.sellPrice(silver: 50);
            Item.rare = ItemRarityID.White;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.CrimtaneBar, 12);
            recipe.AddIngredient(ItemID.TissueSample, 6);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}
