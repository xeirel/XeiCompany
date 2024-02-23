using GameNetcodeStuff;
using HarmonyLib;
using System;
using UnityEngine;

namespace XeiCompany.Patches
{
    [HarmonyPatch(typeof(PlayerControllerB))]
    internal class PlayerControllerBPatch
    {
        [HarmonyPatch("Update")]
        [HarmonyPostfix] 
        static void carryWeightPatch(ref float ___carryWeight)
        {
            ___carryWeight = 1f;
        }

    }
    internal class PlayerControllerGUIPatch
    {
        [HarmonyPatch("OnGUI")]
        [HarmonyPostfix]
        static void OnGUIPatch()
        {
            Rect labelRect = new Rect(10, 10, 200, 20);
            string labelText = "XeiCompany Loaded.";
            GUIStyle style = GUI.skin.label;

            GUI.Label(labelRect, labelText, style);
        }
    }
}
