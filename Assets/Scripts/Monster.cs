using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    //float maxDistance = 10;
    private bool triggered=false;
    void Start()
    {
    }
    void OnMouseOver()
    {
        if (!triggered)
        {
            triggered = true;
            StartCoroutine(Scare());
        }
        
    }



    IEnumerator Scare()
    {
        this.transform.Translate(4,0,0);
        yield return new WaitForSeconds(1);
        this.transform.Translate(-4, 0, 0);
    }
}
