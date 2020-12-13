using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpookyDoor : MonoBehaviour
{
    public GameObject left;
    public GameObject right;
    public float close = 2.4f;
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
   

    // Update is called once per frame
    void Update()
    {
        if (triggered)
        {
            if (left.transform.position.x > this.transform.position.x + close)
            {
                left.transform.Translate(-1 * speed * Time.deltaTime, 0f, 0f);
                right.transform.Translate(1 * speed * Time.deltaTime, 0f, 0f);
            }
        }
    }
}
