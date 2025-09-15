using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace CharaMenu.Mods
{
    internal class Noclip
    {
        public static void NoclipMod()
        {
            if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.2f)
            {
                foreach (MeshCollider meshCollider in Resources.FindObjectsOfTypeAll<MeshCollider>())
                {
                    meshCollider.enabled = false;
                }
            }
            else
            {
                foreach (MeshCollider meshCollider2 in Resources.FindObjectsOfTypeAll<MeshCollider>())
                {
                    meshCollider2.enabled = true;
                }
            }
        }
    }
}
