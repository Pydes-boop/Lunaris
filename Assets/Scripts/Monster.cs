using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    float maxDistance = 10;
    void Start()
    {
    }
    void FixedUpdate()
    {

        // Will contain the information of which object the raycast hit
        RaycastHit hit;

        // if raycast hits, it checks if it hit an object with the tag Player
        if (Physics.Raycast(transform.position, transform.forward, out hit, maxDistance) &&
                    hit.collider.gameObject.CompareTag("Player"))

        {
            Debug.Log("nice");
            // Starts the countdown to destroy the enemy
            StartCoroutine(Scare());

        }

    }



    IEnumerator Scare()
    {
        this.transform.Translate(4,0,0);
        yield return new WaitForSeconds(3);
        this.transform.Translate(-4, 0, 0);
    }
}
