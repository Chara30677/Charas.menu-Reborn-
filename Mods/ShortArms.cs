using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace CharaMenu.Mods
{
    internal class ShortArms
    {
        public static void ShortArmsMod()
        {
            GameObject.Find("GorillaPlayer").transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }

        public static void ResetArms()
        {
            GameObject.Find("GorillaPlayer").transform.localScale = Vector3.one;
        }
    }
}
