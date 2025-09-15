using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharaMenu.Mods
{
    internal class DestroyAll
    {
        public static void DestroyAllMod()
        {
            if (!ControllerInputPoller.instance.leftControllerTriggerButton)
                return;
            {
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                PhotonNetwork.DestroyAll();
                // how to use
                // Make the players rejoin and their player model body’s and stuff will be destroyed
            }
        }
    }
}
