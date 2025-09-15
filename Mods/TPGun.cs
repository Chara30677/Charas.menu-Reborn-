using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace CharaMenu.Mods
{
    internal class TPGun
    {
        public static void TpGun()
        {

            if (ControllerInputPoller.instance.rightGrab)
            {


                Physics.Raycast(GorillaLocomotion.GTPlayer.Instance.rightControllerTransform.position, -GorillaLocomotion.GTPlayer.Instance.rightControllerTransform.up, out var hitInfo);
                pointer = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                pointer.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                pointer.GetComponent<Renderer>().material.color = new Color32(102, 255, 0, 0);
                pointer.transform.position = hitInfo.point;
                GameObject.Destroy(pointer.GetComponent<BoxCollider>());
                GameObject.Destroy(pointer.GetComponent<Rigidbody>());
                GameObject.Destroy(pointer.GetComponent<Collider>());
                if (ControllerInputPoller.instance.rightControllerIndexFloat >= 0.1)
                {
                    GameObject.Destroy(pointer, Time.deltaTime);
                    GorillaLocomotion.GTPlayer.Instance.transform.position = pointer.transform.position;
                    GorillaLocomotion.GTPlayer.Instance.GetComponent<Rigidbody>().velocity = pointer.transform.position;
                }

                if (pointer != null)
                {
                    GameObject.Destroy(pointer, Time.deltaTime);
                }

            }

        }
        public static GameObject pointer;
    }
}
