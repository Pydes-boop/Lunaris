using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBehavior : MonoBehaviour
{
    public GameObject lightGameObject;
    private Light lightComp;
    public GameObject lightGameObject2;
    private Light lightComp2;

    int counter=0;
    bool switcher = false;

    void Start()
    {
        lightComp = lightGameObject.GetComponent<Light>();
        lightComp2 = lightGameObject2.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {/*
        counter++;
        if (counter > 240)
        {
            lightComp.enabled = switcher;
            lightComp2.enabled = switcher;
            counter = 0;
            switcher = !switcher;
        }
        */
    }
}
