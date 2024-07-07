using Gear;
using HarmonyLib;

namespace ColorCrosshair
{
    [HarmonyPatch]
    internal static class WeaponPatch
    {
        [HarmonyPatch(typeof(BulletWeapon), nameof(BulletWeapon.SetupArchetype))]
        [HarmonyPostfix]
        [HarmonyWrapSafe]
        public static void Post_SetupArchetype(BulletWeapon __instance)
        {
            if (__instance.m_archeType != null)
                __instance.m_archeType.m_triggerNeedsPress = false;
        }
    }
}