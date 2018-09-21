using UnityEngine;
using System.Collections;

namespace NewtonVR.Example
{
    public class NVRExampleGun : NVRInteractableItem
    {
        public GameObject BulletPrefab;
        public GameObject WaveViz; 
        public Transform FirePoint;

        public Vector3 BulletForce = new Vector3(0, 0, 250);

        public override void UseButtonDown()
        {
            base.UseButtonDown();

            GameObject bullet = GameObject.Instantiate(BulletPrefab);
            GameObject wave = GameObject.Instantiate(WaveViz);
            wave.transform.position = FirePoint.position;
            bullet.transform.position = FirePoint.position;
            bullet.transform.forward = FirePoint.forward;

            bullet.GetComponent<Rigidbody>().AddRelativeForce(BulletForce);

            AttachedHand.TriggerHapticPulse(500);
        }
    }
}