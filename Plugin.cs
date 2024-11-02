using BepInEx;

namespace AbelLethalHelper
{
    [BepInPlugin(ModGUID, "Lethal Things", "1.0.1")]
    public class Plugin : BaseUnityPlugin
    {
        public const string ModGUID = "com.abelmuak.libs.lethalthings";
        private void Awake()
        {
            Logger.LogInfo($"Plugin {ModGUID} is loaded!");
        }
    }
}
