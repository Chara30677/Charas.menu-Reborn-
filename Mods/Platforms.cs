using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace CharaMenu.Mods
{
    internal class Platforms
    {
        public static void PlatformMod()

        {
            if (ControllerInputPoller.instance.leftGrab && leftplat == null)
            {
                leftplat = CreatePlatformOnHand(GorillaTagger.Instance.leftHandTransform);
            }

            if (ControllerInputPoller.instance.rightGrab && rightplat == null)
            {
                rightplat = CreatePlatformOnHand(GorillaTagger.Instance.rightHandTransform);
            }

            if (ControllerInputPoller.instance.rightGrabRelease && rightplat != null)
            {
                rightplat.Disable();
                rightplat = null;

            }

            if (ControllerInputPoller.instance.leftGrabRelease && leftplat != null)
            {
                leftplat.Disable();
                leftplat = null;
            }
        }
        private static GameObject leftplat = null;
        private static GameObject rightplat = null;
        private static GameObject CreatePlatformOnHand(Transform handTransform)
        {
            GameObject plat = GameObject.CreatePrimitive(PrimitiveType.Cube);
            plat.transform.localScale = new Vector3(0.025f, 0.3f, 0.4f);

            plat.transform.position = handTransform.position;
            plat.transform.rotation = handTransform.rotation;

            float h = (Time.frameCount / 180f) % 1f;
            plat.GetComponent<Renderer>().material.color = Color.black;
            return plat;
        } //working platforms code
    }
}
