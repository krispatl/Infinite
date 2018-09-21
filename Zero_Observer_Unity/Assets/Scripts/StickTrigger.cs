using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickTrigger : AkTriggerBase
{


    void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag.Equals("Surface"))
            {
                
                    GetComponent<StickSound>().Hit();
           

        }
        }


        // Update is called once per frame
        void Update () {
		
	}
}
