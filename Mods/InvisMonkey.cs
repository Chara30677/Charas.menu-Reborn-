using System;
using System.Collections.Generic;
using System.Text;

namespace CharaMenu.Mods
{
    internal class InvisMonkey
    {
        public static int IsInvis = 0;
        private static bool buttonPreviouslyPressed = false;

        public static void Invis()
        {
            bool buttonPressed = ControllerInputPoller.instance.rightControllerSecondaryButton;
            if (buttonPressed && !buttonPreviouslyPressed)
            {
                IsInvis = (IsInvis == 1) ? 0 : 1;
            }

            buttonPreviouslyPressed = buttonPressed;

            if (IsInvis != 0)
            {
                GorillaTagger.Instance.offlineVRRig.headBodyOffset.x = 180f;
            }
            else
            {
                GorillaTagger.Instance.offlineVRRig.headBodyOffset.x = 0f;
            }
        }
    }
}