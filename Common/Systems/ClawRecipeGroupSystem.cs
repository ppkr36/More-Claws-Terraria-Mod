using ClawProgression.Content.Claws;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ClawProgression.Common.Systems
{
    public class ClawRecipeGroupSystem : ModSystem
    {
        // До хардмода
        public static int CopperTinClaws { get; private set; } = -1;
        public static int IronLeadClaws { get; private set; } = -1;
        public static int SilverTungstenClaws { get; private set; } = -1;
        public static int GoldPlatinumClaws { get; private set; } = -1;
        public static int DemoniteCrimtaneClaws { get; private set; } = -1;

        // Хардмод
        public static int CobaltPalladiumClaws { get; private set; } = -1;
        public static int MythrilOrichalcumClaws { get; private set; } = -1;
        public static int AdamantiteTitaniumClaws { get; private set; } = -1;

        public override void AddRecipeGroups()
        {
            // Медь или олово
            CopperTinClaws = RegisterClawGroup(
                key: "CopperTinClaws",
                englishDefault: "Copper or Tin Claws",
                ModContent.ItemType<CopperClaw>(),
                ModContent.ItemType<TinClaw>()
            );

            // Железо или свинец
            IronLeadClaws = RegisterClawGroup(
                key: "IronLeadClaws",
                englishDefault: "Iron or Lead Claws",
                ModContent.ItemType<IronClaw>(),
                ModContent.ItemType<LeadClaw>()
            );

            // Серебро или вольфрам
            SilverTungstenClaws = RegisterClawGroup(
                key: "SilverTungstenClaws",
                englishDefault: "Silver or Tungsten Claws",
                ModContent.ItemType<SilverClaw>(),
                ModContent.ItemType<TungstenClaw>()
            );

            // Золото или платина
            GoldPlatinumClaws = RegisterClawGroup(
                key: "GoldPlatinumClaws",
                englishDefault: "Gold or Platinum Claws",
                ModContent.ItemType<GoldClaw>(),
                ModContent.ItemType<PlatinumClaw>()
            );

            // Демонит или кримтан
            DemoniteCrimtaneClaws = RegisterClawGroup(
                key: "DemoniteCrimtaneClaws",
                englishDefault: "Demonite or Crimtane Claws",
                ModContent.ItemType<DeathbringerClaw>(),
                ModContent.ItemType<NightmareClaw>()
            );

            // Кобальт или палладий
            CobaltPalladiumClaws = RegisterClawGroup(
                key: "CobaltPalladiumClaws",
                englishDefault: "Cobalt or Palladium Claws",
                ModContent.ItemType<CobaltClaw>(),
                ModContent.ItemType<PalladiumClaw>()
            );

            // Мифрил или орихалк
            MythrilOrichalcumClaws = RegisterClawGroup(
                key: "MythrilOrichalcumClaws",
                englishDefault: "Mythril or Orichalcum Claws",
                ModContent.ItemType<MythrilClaw>(),
                ModContent.ItemType<OrichalcumClaw>()
            );

            // Адамантит или титан
            AdamantiteTitaniumClaws = RegisterClawGroup(
                key: "AdamantiteTitaniumClaws",
                englishDefault: "Adamantite or Titanium Claws",
                ModContent.ItemType<AdamantiteClaw>(),
                ModContent.ItemType<TitaniumClaw>()
            );
        }

        /// <summary>
        /// Создаёт, локализует и регистрирует одну группу когтей.
        /// Возвращает ID зарегистрированной группы.
        /// </summary>
        private int RegisterClawGroup(
            string key,
            string englishDefault,
            params int[] itemTypes)
        {
            // Получаем локализованный текст группы.
            // Полный ключ будет:
            // Mods.ClawProgression.RecipeGroups.{key}
            LocalizedText displayName = Mod.GetLocalization(
                $"RecipeGroups.{key}",
                () => englishDefault
            );

            // Создаём группу.
            // itemTypes содержит ID всех предметов, которые могут
            // заменять друг друга в рецепте.
            RecipeGroup group = new RecipeGroup(
                () => displayName.Value,
                itemTypes
            );

            // Регистрируем группу и возвращаем её числовой ID.
            return RecipeGroup.RegisterGroup(
                $"{Mod.Name}:{key}",
                group
            );
        }

        public override void Unload()
        {
            // Очищаем сохранённые ID при выгрузке/перезагрузке мода.
            CopperTinClaws = -1;
            IronLeadClaws = -1;
            SilverTungstenClaws = -1;
            GoldPlatinumClaws = -1;
            DemoniteCrimtaneClaws = -1;

            CobaltPalladiumClaws = -1;
            MythrilOrichalcumClaws = -1;
            AdamantiteTitaniumClaws = -1;
        }
    }
}