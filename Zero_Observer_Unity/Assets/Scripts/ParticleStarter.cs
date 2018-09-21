using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleStarter : MonoBehaviour
{

    public GameObject particleSystemPrefab;

    void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
          
            Instantiate(particleSystemPrefab, contact.point, Quaternion.identity);
        }
    }
}