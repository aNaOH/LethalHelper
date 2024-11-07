using BepInEx;
using BepInEx.Logging;

namespace AbelMuak.Libs.LethalHelper
{
    [BepInPlugin(PLUGIN_GUID, PLUGIN_NAME, PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        internal static new ManualLogSource Logger;

        public const string PLUGIN_GUID = "com.abelmuak.libs.lethalthings";
        public const string PLUGIN_NAME = "Lethal Helper";
        public const string PLUGIN_VERSION = "1.0.3";

        private void Awake()
        {
            // Plugin startup logic
            Logger = base.Logger;
            Logger.LogInfo($"Plugin {PLUGIN_GUID} is loaded!");
        }
    }
}
