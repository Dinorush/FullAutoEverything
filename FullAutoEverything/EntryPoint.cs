﻿using BepInEx;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;

namespace FullAutoEverything
{
    [BepInPlugin("Dinorush." + MODNAME, MODNAME, "1.0.2")]
    internal sealed class EntryPoint : BasePlugin
    {
        public const string MODNAME = "FullAutoEverything";

        public override void Load()
        {
            Log.LogMessage("Loading " + MODNAME);
            new Harmony(MODNAME).PatchAll();
            Log.LogMessage("Loaded " + MODNAME);
        }
    }
}