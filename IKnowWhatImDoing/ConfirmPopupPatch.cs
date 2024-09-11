using Client.Player.Interactions;
using HarmonyLib;
using System;
using System.Reflection;
using UI.Popup;
using UnityEngine;

namespace IKnowWhatImDoing
{
    [HarmonyPatch(typeof(ConfirmPopup))]
    internal class ConfirmPopupPatch
    {
        private static readonly MethodInfo ConfirmedMethod = AccessTools.Method(typeof(ConfirmPopup), "Confirmed");

        [HarmonyPostfix]
        [HarmonyPatch("Show", new Type[] { typeof(string), typeof(string), typeof(Action), typeof(Action), typeof(Sprite) })]
        static void Show1(ConfirmPopup __instance)
        {
            ConfirmedMethod.Invoke(__instance, null);
        }

        [HarmonyPostfix]
        [HarmonyPatch("Show", new Type[] { typeof(ContextInfo), typeof(Action), typeof(Action), typeof(Sprite) })]
        static void Show2(ConfirmPopup __instance)
        {
            ConfirmedMethod.Invoke(__instance, null);
        }
    }
}
