using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace CharaMenu.Mods
{
    internal class LongArms
    {
        public static void LongArmsMod()
        {
            GameObject.Find("GorillaPlayer").transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
        }

        public static void ResetArms()
        {
            GameObject.Find("GorillaPlayer").transform.localScale = Vector3.one;
        }
    }
}
