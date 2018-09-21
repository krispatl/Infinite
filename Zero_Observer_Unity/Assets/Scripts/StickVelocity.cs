using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AK;

public class StickVelocity : MonoBehaviour
{
    public Material sight;
    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag.Equals("Surface"))
        {
            StartCoroutine("Velocity");
        }
    }

    void Update()
    {
       
    }

    IEnumerator Velocity ()

    {
        Vector3 initialVelocity, newVelocity;

        initialVelocity = transform.GetComponent<Rigidbody>().velocity;
        yield return null;

        newVelocity = transform.GetComponent<Rigidbody>().velocity;

        Vector3 result = initialVelocity - newVelocity;

        Debug.Log("Relative Velocity: " + result.magnitude);
        AkSoundEngine.SetRTPCValue("StickIntensity", result.magnitude*10.0f);
        AkSoundEngine.PostEvent("Play_WalkingStick", this.gameObject);
        sight.SetFloat("_dissolve", result.magnitude*.10f);
        yield return new WaitForSeconds(2);
        sight.SetFloat("_dissolve", 0);
    }
        
}
