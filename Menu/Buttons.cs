using CharaMenu.Classes;
using CharaMenu.Mods;
using static CharaMenu.Settings;

namespace CharaMenu.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Opens the main settings page for the menu."},
                new ButtonInfo { buttonText = "Long Arms", method =() => LongArms.LongArmsMod(), disableMethod =() => LongArms.ResetArms(), toolTip = "Gives you Longer Arms"},
                new ButtonInfo { buttonText = "Speed boost", method =() => SpeedBoost.SpeedBoostMod(), toolTip = "Gives the you a speed boost. Somewhat UND", isTogglable = true},
                new ButtonInfo { buttonText = "Platforms", method =() => Platforms.PlatformMod(), toolTip = "Press your <color=purple>(G)</color> button for platforms.", isTogglable = true},
                new ButtonInfo { buttonText = "Invis Monkey", method =() => InvisMonkey.Invis(), toolTip = "Press your <color=purple>(B)</color> button to go invisible", isTogglable = true},
                new ButtonInfo { buttonText = "Noclip", method =() => Noclip.NoclipMod(), toolTip = "Allows you to go through objects when you hold <color=purple>(T)</color>.", isTogglable = true},
                new ButtonInfo { buttonText = "Ghost Monkey", method =() => GhostMonkey.ghostey(), toolTip = "Leaves your Rig wherever you pressed your <color=purple>(A)</color> Button.", isTogglable = true},
                new ButtonInfo { buttonText = "Car Monkey", method =() => CarMonkey.CarMonke(), toolTip = "Allows you to fly around as if your driving a car.", isTogglable = true},
                new ButtonInfo { buttonText = "TP Gun", method =() => TPGun.TpGun(), toolTip = "Allows you to teleport where you desire.", isTogglable = true},
                new ButtonInfo { buttonText = "Destroy All", method =() => DestroyAll.DestroyAllMod(),toolTip = "Breaks any newlyy joined player's game by making every other player invisible.", isTogglable = true},
                new ButtonInfo { buttonText = "Disable Network Trigger", method =() => DisableNetworkTrigger.NetworkTriggerRemove(), toolTip = "Disables network triggers.", isTogglable = true},
                new ButtonInfo { buttonText = "Hold Rig", method =() => HoldRig.HoldRigMod(), toolTip = "Allows you to hold your rig when holding your <color=purple>(G)</color> button.", isTogglable = true},
                new ButtonInfo { buttonText = "No Tag Freeze", method =() => NoTagFreeze.NoTagFreezeMod(), toolTip = "Disables the tag freeze when you get tagged in infection.", isTogglable = true},
                new ButtonInfo { buttonText = "Short Arms", method =() => ShortArms.ShortArmsMod(), disableMethod =() => ShortArms.ResetArms(), toolTip = "Makes your arms short (Good for trolling as a little timmy)", isTogglable = true},
            },

            new ButtonInfo[] { // Settings
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Menu", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
                new ButtonInfo { buttonText = "Movement", method =() => SettingsMods.MovementSettings(), isTogglable = false, toolTip = "Opens the movement settings for the menu."},
                new ButtonInfo { buttonText = "Projectile", method =() => SettingsMods.ProjectileSettings(), isTogglable = false, toolTip = "Opens the projectile settings for the menu."},
            },

            new ButtonInfo[] { // Menu Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "Right Hand", enableMethod =() => SettingsMods.RightHand(), disableMethod =() => SettingsMods.LeftHand(), toolTip = "Puts the menu on your right hand."},
                new ButtonInfo { buttonText = "Notifications", enableMethod =() => SettingsMods.EnableNotifications(), disableMethod =() => SettingsMods.DisableNotifications(), enabled = !disableNotifications, toolTip = "Toggles the notifications."},
                new ButtonInfo { buttonText = "FPS Counter", enableMethod =() => SettingsMods.EnableFPSCounter(), disableMethod =() => SettingsMods.DisableFPSCounter(), enabled = fpsCounter, toolTip = "Toggles the FPS counter."},
                new ButtonInfo { buttonText = "Disconnect Button", enableMethod =() => SettingsMods.EnableDisconnectButton(), disableMethod =() => SettingsMods.DisableDisconnectButton(), enabled = disconnectButton, toolTip = "Toggles the disconnect button."},
            },

            new ButtonInfo[] { // Movement Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
            },

            new ButtonInfo[] { // Projectile Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
            },
        };
    }
}
