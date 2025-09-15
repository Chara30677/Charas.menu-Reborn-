using System;
using System.Collections.Generic;
using System.Text;

namespace CharaMenu.Mods
{
    internal class SpeedBoost
    {
        public static void SpeedBoostMod()
        {
            GorillaLocomotion.GTPlayer.Instance.maxJumpSpeed = 5f;
            GorillaLocomotion.GTPlayer.Instance.jumpMultiplier = 5f;
        }
    }
}
