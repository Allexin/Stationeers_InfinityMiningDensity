using BepInEx;
using BepInEx.Configuration;
using HarmonyLib;
using Objects.Rockets.Mining;
using UnityEngine;

namespace InfinityMiningDensity
{
    [BepInPlugin(ModGuid, ModName, ModVersion)]
    public class InfinityMiningDensityMod : BaseUnityPlugin
    {
        public const string ModGuid = "basovav.infinityminingdensity";
        public const string ModName = "Infinity Mining Density";
        public const string ModVersion = "1.0.0";
        
        public static ConfigEntry<float> DepletedMultiplier;
        
        public const float MIN_DENSITY_FLOOR = 0.1f;
        private static Harmony _harmony;

        void Awake()
        {
            // Initialize configuration settings
            DepletedMultiplier = Config.Bind("Mining", "DepletedMultiplier", 0.25f,
                new ConfigDescription("Yield multiplier when density is at minimum floor", new AcceptableValueRange<float>(0.1f, 1.0f)));
            
            _harmony = new Harmony(ModGuid);
            _harmony.PatchAll();
            Logger.LogInfo($"Plugin {ModName} is loaded!");
            Logger.LogInfo($"Min Density Floor: {MIN_DENSITY_FLOOR}");
            Logger.LogInfo($"Depleted Multiplier: {DepletedMultiplier.Value}");
        }

        void OnDestroy()
        {
            _harmony?.UnpatchAll(ModGuid);
        }
    }

    [HarmonyPatch(typeof(MineableDeposit), "OnDepositMined")]
    public static class MineableDeposit_OnDepositMined_Patch
    {
        static void Postfix(MineableDeposit __instance)
        {
            if (__instance.Density < InfinityMiningDensityMod.MIN_DENSITY_FLOOR)
            {
                __instance.Density = InfinityMiningDensityMod.MIN_DENSITY_FLOOR;
            }
        }
    }

    [HarmonyPatch(typeof(MineableDeposit), "IsDepleted", MethodType.Getter)]
    public static class MineableDeposit_IsDepleted_Patch
    {
        static void Postfix(ref bool __result)
        {
            // Deposits never become completely depleted
            __result = false;
        }
    }

    [HarmonyPatch(typeof(MineableDeposit), "OreQuantity")]
    public static class MineableDeposit_OreQuantity_Patch
    {
        static void Prefix(MineableDeposit __instance)
        {
            // Restore density to minimum level if it was completely depleted
            if (__instance.Density <= 0f)
            {
                __instance.Density = InfinityMiningDensityMod.MIN_DENSITY_FLOOR;
            }
        }

        static void Postfix(MineableDeposit __instance, ref int __result)
        {
            // If density is at minimum, apply reduced multiplier
            if (__instance.Density <= InfinityMiningDensityMod.MIN_DENSITY_FLOOR)
            {
                __result = Mathf.RoundToInt(__result * InfinityMiningDensityMod.DepletedMultiplier.Value);
                // Guarantee minimum of 1 unit
                if (__result < 1)
                {
                    __result = 1;
                }
            }
        }
    }
}
