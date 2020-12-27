using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locker : MonoBehaviour
{
	public GameObject left;
	public GameObject right;
	public float opening = 0.69f;
	public float speed = 150f;
	private bool onTrigger;
	private bool doorOpen;
	private bool interaction;
	private bool opened;

	void OnTriggerEnter(Collider other)
	{
		onTrigger = true;
	}

	void OnTriggerExit(Collider other)
	{
		onTrigger = false;
	}

	void Update()
	{
		if (interaction)
		{
            if (!doorOpen)
            {
				//closes the door
				if (left.transform.rotation.y > 0)
				{
					left.transform.Rotate(0f, 0f, -1 * speed * Time.deltaTime);
					right.transform.Rotate(0f, 0f,1 * speed * Time.deltaTime);
                    if (left.transform.rotation.y < 0.1)
                    {
						opened = false;
                    }
				}
            }
            else
            {
				//opens the door
				if (left.transform.rotation.y < this.transform.rotation.y + opening)
				{
					left.transform.Rotate(0f, 0f, 1 * speed * Time.deltaTime);
					right.transform.Rotate(0f, 0f, -1 * speed * Time.deltaTime);
                    if (left.transform.rotation.y > 0.5)
                    {
						opened = true;
                    }
				}
			}
			
		}
	}

	void OnGUI()
	{
		if (onTrigger)
		{
            if(!doorOpen)
			{
				GUI.Box(new Rect(0, 0, 200, 25), "Press 'E' to open locker");

				if (Input.GetKeyDown(KeyCode.E)&&!opened)
				{
					interaction = true;
					doorOpen = true;
				}
			}
			else
			{

				GUI.Box(new Rect(0, 0, 200, 25), "Press 'E' to close Locker");
				if (Input.GetKeyDown(KeyCode.E)&&opened)
				{
					Debug.Log("wtf");
					interaction = true;
					doorOpen = false;
				}
			}

		}
        
	}
}
