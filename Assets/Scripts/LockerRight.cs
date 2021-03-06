﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LockerRight : MonoBehaviour
{
	public GameObject right = null;
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
				if (-right.transform.localRotation.y > 0)
				{
					right.transform.Rotate(0f, 0f, 1 * speed * Time.deltaTime);
					if (-right.transform.localRotation.y < 0.1)
					{
						opened = false;
					}
				}
			}
			else
			{
				//opens the door
				if (-right.transform.localRotation.y < opening)
				{
					right.transform.Rotate(0f, 0f, -1 * speed * Time.deltaTime);
					if (-right.transform.localRotation.y > 0.5)
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
			if (!doorOpen)
			{
				GUI.Box(new Rect(0, 0, 200, 25), "Press 'E' to open locker");

				if (Input.GetKeyDown(KeyCode.E) && !opened)
				{
					interaction = true;
					doorOpen = true;
				}
			}
			else
			{

				GUI.Box(new Rect(0, 0, 200, 25), "Press 'E' to close Locker");
				if (Input.GetKeyDown(KeyCode.E) && opened)
				{
					interaction = true;
					doorOpen = false;
				}
			}

		}

	}
}
