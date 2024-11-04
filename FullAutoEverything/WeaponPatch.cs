using Gear;
using HarmonyLib;

namespace FullAutoEverything
{
    [HarmonyPatch]
    internal static class WeaponPatch
    {
        [HarmonyPatch(typeof(BWA_Burst), nameof(BWA_Burst.Setup))]
        [HarmonyPatch(typeof(BWA_Semi), nameof(BWA_Semi.Setup))]
        [HarmonyPostfix]
        [HarmonyWrapSafe]
        public static void Post_SetupArchetype(BulletWeaponArchetype __instance)
        {
            if (__instance != null)
                __instance.m_triggerNeedsPress = false;
        }
    }
}