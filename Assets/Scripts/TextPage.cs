using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class TextPage : MonoBehaviour
{
	public GameObject player;
	private bool onTrigger = false;
	private bool collected = false;
	public String text=null;
	void OnTriggerEnter(Collider other)
	{
		onTrigger = true;
	}

	void OnTriggerExit(Collider other)
	{
		onTrigger = false;
	}
    void OnGUI()
    {
		if (onTrigger)
		{
			if (!collected)
			{
				GUI.Box(new Rect(0, 0, 200, 25), "Press 'E' to collect Paper");
				if (Input.GetKeyDown(KeyCode.E))
				{
					player.GetComponent<PlayerDex>().addPage(text);
					collected = true;
				}
			}
		}
		
	}
}
