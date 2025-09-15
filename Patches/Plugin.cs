using BepInEx;
using System.ComponentModel;

namespace CharaMenu.Patches
{
    [Description(CharaMenu.PluginInfo.Description)]
    [BepInPlugin(CharaMenu.PluginInfo.GUID, CharaMenu.PluginInfo.Name, CharaMenu.PluginInfo.Version)]
    public class HarmonyPatches : BaseUnityPlugin
    {
        private void OnEnable()
        {
            Menu.ApplyHarmonyPatches();
        }

        private void OnDisable()
        {
            Menu.RemoveHarmonyPatches();
        }
    }
}
