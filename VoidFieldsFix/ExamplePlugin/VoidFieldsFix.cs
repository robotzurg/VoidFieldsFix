using BepInEx;
using R2API;
using RoR2;
using EntityStates;
using UnityEngine;
using UnityEngine.AddressableAssets;
using System;

namespace VoidFieldsFix
{
    [BepInDependency(LanguageAPI.PluginGUID)]
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]

    public class VoidFieldsFix : BaseUnityPlugin
    {
        public const string PluginGUID = PluginAuthor + "." + PluginName;
        public const string PluginAuthor = "Jeffdev";
        public const string PluginName = "VoidFieldsFix";
        public const string PluginVersion = "1.0.0";

        public void Awake()
        {
            Log.Init(Logger);

            On.RoR2.FogDamageController.Start += FogDamageController_Start;
        }

        private void FogDamageController_Start(On.RoR2.FogDamageController.orig_Start orig, FogDamageController self)
        {
            self.incrementExponentially = false;
            orig(self);
        }
    }
}
