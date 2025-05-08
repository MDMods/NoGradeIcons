using HarmonyLib;
using Il2CppAssets.Scripts.UI.Panels;

namespace NoGradeIcons.Patches
{
    internal class DifficultyReverter
    {
        [HarmonyPatch(typeof(PnlStage.DiffItem), nameof(PnlStage.DiffItem.ChangeSchemeByEvalue))]
        internal class RemoveGradeIconsPatch
        {
            private static bool Prefix() => false;
        }
    }
}