using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceTrack : MonoBehaviour
{

    public GameObject Player;
    public GameObject source;
    float distance_;



    void start()
    {

    }

    void Update()
    {
        distance_ = Vector3.Distance(Player.transform.position, source.transform.position);
        if (distance_ > 0 && distance_ < 1.0f)
        {
            Debug.Log("Distance: " + distance_);
            AkSoundEngine.SetSwitch("DialogCloseness", "Close", source);

        }
        else if (distance_ > 1.0f && distance_ < 5.0f)
        {
            Debug.Log("Distance: " + distance_);
            AkSoundEngine.SetSwitch("DialogCloseness", "Neutral", source);

        }
        else if (distance_ >= 5.0f)
        {
            Debug.Log("Distance: " + distance_); 
            AkSoundEngine.SetSwitch("DialogCloseness", "Far", source);
        }
    }
}