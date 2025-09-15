using System;
using System.Collections.Generic;
using System.Text;

namespace CharaMenu.Mods
{
    internal class HoldRig
    {
        public static void HoldRigMod()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                GorillaTagger.Instance.offlineVRRig.enabled = false;
                GorillaTagger.Instance.offlineVRRig.transform.position = GorillaLocomotion.GTPlayer.Instance.rightControllerTransform.position;
            }

        }
    }
}
