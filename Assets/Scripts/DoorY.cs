using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorY : MonoBehaviour
{
    public GameObject left;
    public GameObject right;
    public float openingL = 1.2f;
    public float close = -0.39f;
    public float speed = 1;
    bool triggered;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
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
            if (right.transform.position.z < this.transform.position.z + openingL)
            {
                left.transform.Translate(1 * speed * Time.deltaTime, 0f, 0f);
                right.transform.Translate(-1 * speed * Time.deltaTime, 0f, 0f);
            }
        }
        else
        {
            if (right.transform.position.z > this.transform.position.z + close)
            {
                left.transform.Translate(-1 * speed * Time.deltaTime, 0f, 0f);
                right.transform.Translate(1 * speed * Time.deltaTime, 0f, 0f);
            }
        }
    }
}
