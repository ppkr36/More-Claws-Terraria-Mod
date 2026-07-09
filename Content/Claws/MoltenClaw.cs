using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace ClawProgression.Content.Claws
{
    public class MoltenClaw : ModItem
    {
        public override void SetDefaults()
        {
            Item.DamageType = DamageClass.Melee;
            Item.useTime = 13;
            Item.useAnimation = 17;
            Item.damage = 6;
            Item.pick = 100;
            Item.width = 32;
            Item.height = 32;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.axe = 21;
            Item.tileBoost = -2;
            Item.UseSound = SoundID.Item1;
            Item.value = Item.sellPrice(silver: 50);
            Item.rare = ItemRarityID.Orange;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.HellstoneBar, 6);
            recipe.AddRecipeGroup(RecipeGroupID.Wood, 12);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.NextBool(3))
            {
                Dust dust = Dust.NewDustDirect(
                    new Vector2(hitbox.X, hitbox.Y),
                    hitbox.Width,
                    hitbox.Height,
                    DustID.Torch,
                    player.direction * 2f,
                    0f,
                    100,
                    default,
                    1.2f
                );

                dust.noGravity = true;
                dust.velocity *= 0.4f;
            }
        }
    }
}
