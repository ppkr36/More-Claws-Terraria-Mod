using System.Collections.Generic;
using ClawProgression.Content.Claws;
using Terraria;
using Terraria.ModLoader;

namespace ClawProgression.Common.Players
{
    public class MoreClawsPlayer : ModPlayer
    {
        public override IEnumerable<Item> AddStartingItems(bool mediumCoreDeath)
        {
            if (mediumCoreDeath)
            {
                yield break;
            }

            Item copperClaw = new Item();
            copperClaw.SetDefaults(ModContent.ItemType<CopperClaw>());

            yield return copperClaw;
        }
    }
}