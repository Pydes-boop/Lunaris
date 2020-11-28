using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchBehavior : MonoBehaviour
{
    public GameObject lightGameObject;
    private Light lightComp;
    private int counter = 0;

    // Start is called before the first frame update
    void Start()
    {

        // Add the light component
       lightComp = lightGameObject.GetComponent<Light>();
        //lightComp.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {   //Change the collor of the Light
        //lightComp.color = Color.blue;
        //Change the intensity of Light
        //lightComp.intensity -= 1;
        //Slowly change the intensity of the Light
       /* if(lightComp.intensity > 0)
        {
            lightComp.intensity -= 0.05f;
        }*/
        //Shows the light or hides it (On,OFF)
        //lightComp.enabled = false;
        /*
        counter++;
        if(counter >= 250)
        {
            lightComp.enabled = true;
        }*/




    }
}
