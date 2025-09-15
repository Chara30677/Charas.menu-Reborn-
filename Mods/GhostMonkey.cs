using System;
using System.Collections.Generic;
using System.Text;

namespace CharaMenu.Mods
{
    internal class GhostMonkey
    {
     
        private static bool previousState = false;
        private static bool isEnabled = true;

        public static void ghostey()
        {
            bool currentState = ControllerInputPoller.instance.rightControllerPrimaryButton;


            if (currentState && !previousState)
            {

                isEnabled = !isEnabled;
                GorillaTagger.Instance.offlineVRRig.enabled = isEnabled;
            }


            previousState = currentState;
        }
    }
}

