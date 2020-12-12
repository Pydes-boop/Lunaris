using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorL : MonoBehaviour
{
    public GameObject left;
    public GameObject right;
    public float openingL = 10f;
    public float close = 2.4f;
    public float speed;
    bool triggered;
    bool opening;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            triggered = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            triggered = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (triggered)
        {
            if(left.transform.position.x < this.transform.position.x + openingL)
            {
                left.transform.Translate(1* speed * Time.deltaTime, 0f, 0f);
                right.transform.Translate(-1* speed * Time.deltaTime, 0f, 0f);
            }
        }
        else
        {
            if (left.transform.position.x > this.transform.position.x+  close)
            {
                left.transform.Translate(-1 * speed * Time.deltaTime, 0f, 0f);
                right.transform.Translate(1 * speed * Time.deltaTime, 0f, 0f);
            }
        }
    }
}
