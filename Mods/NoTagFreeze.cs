using System;
using System.Collections.Generic;
using System.Text;

namespace CharaMenu.Mods
{
    internal class NoTagFreeze
    {
        public static void NoTagFreezeMod()
        {
            GorillaLocomotion.GTPlayer.Instance.disableMovement = false;
        }
    }
}
