using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisVector : MonoBehaviour {
    public Vector2 Frequency;
    public ParticleSystem ps;
    public float hSliderValue = 1.0F;

    // Use this for initialization
    void Start () {
        ps = GetComponent<ParticleSystem>();
    }
	
	// Update is called once per frame
	void Update () {
        Frequency = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);
        Debug.Log("AxisVector: " + Frequency);
        var main = ps.main;
        main.simulationSpeed = hSliderValue;
        hSliderValue = Frequency.x;
        AkSoundEngine.SetRTPCValue("StickIntensity", Frequency.x*10f);
        AkSoundEngine.PostEvent("Play_WalkingStick", this.gameObject);

        
    }
}
