using BepInEx;
using HarmonyLib;
using UnboundLib;
using UnboundLib.Cards;

namespace EvenSpreadPatch
{
    // These are the mods required for our mod to work
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    // Declares our mod to Bepin
    [BepInPlugin(ModId, ModName, Version)]
    // The game our mod is associated with
    [BepInProcess("Rounds.exe")]
    public class EvenSpreadPatch : BaseUnityPlugin
    {
        private const string ModId = "com.willuwontu.rounds.evenspreadpatch";
        private const string ModName = "Even Spread Patch";
        public const string Version = "0.0.0"; // What version are we on (major.minor.patch)?

        public static EvenSpreadPatch instance { get; private set; }

        void Awake()
        {

        }
        void Start()
        {
            instance = this;

            // Use this to call any harmony patch files your mod may have
            var harmony = new Harmony(ModId);
            harmony.PatchAll();
        }
    }
}
