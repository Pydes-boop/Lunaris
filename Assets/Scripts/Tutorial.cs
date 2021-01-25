using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
	private bool onTrigger = false;

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
			GUI.Box(new Rect(0, 0, 200, 25), "Press W, A, S and D to walk");
			GUI.Box(new Rect(0, 25, 200, 25), "Hold Right Click to Zoom");
		}

	}
}
