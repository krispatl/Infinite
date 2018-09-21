using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreqGunShoot : MonoBehaviour {


    public GameObject WaveVizSmall;
    public GameObject WaveVizLarge;
    public Transform FirePoint;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
     
        Vector2 primaryAxis = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);


        if (primaryAxis.x < 0.0f)

            GameObject.Instantiate(WaveVizSmall, FirePoint.position, FirePoint.rotation);
        

        if (primaryAxis.x > 0.0f)

            GameObject.Instantiate(WaveVizLarge, FirePoint.position, FirePoint.rotation);


    }
}
