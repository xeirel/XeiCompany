using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using XeiCompany.Patches;


namespace XeiCompany
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class XeiCompanyBase : BaseUnityPlugin
    {
        private const string modGUID = "Xeirel.XeiCompany";
        private const string modName = "Xei Company";
        private const string modVersion = "1.0.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        private static XeiCompanyBase Instance;

        internal ManualLogSource mls;

        void Awake()
        {
            if (Instance == null) { Instance = this; }

            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);

            mls.LogInfo("XeiCompany Has Awaken...");
            mls.LogInfo("XeiCompany Has Awaken...");
            mls.LogInfo("XeiCompany Has Awaken...");
            mls.LogInfo("XeiCompany Has Awaken...");
            mls.LogInfo("XeiCompany Has Awaken...");
            mls.LogInfo("XeiCompany Has Awaken...");

            harmony.PatchAll(typeof(XeiCompanyBase));
            harmony.PatchAll(typeof(PlayerControllerBPatch));
            harmony.PatchAll(typeof(PlayerControllerGUIPatch));
        }
    }
}
