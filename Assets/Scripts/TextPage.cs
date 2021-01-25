using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class TextPage : MonoBehaviour
{
	public GameObject player;
	private bool onTrigger = false;
	private bool collected = false;
	public String text;
	private MeshRenderer meshRenderer;

	void Start() {
		meshRenderer = this.gameObject.GetComponent<MeshRenderer>();
	}

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
				GUI.Box(new Rect(0, 25, 200, 25), "Press 'Q' to collect Paper");
				if (Input.GetKeyDown(KeyCode.Q))
				{
					//print(text.Replace("\\n", "\n"));
					player.GetComponent<PlayerDex>().addPage(text.Replace("/n", "\\n").Replace("\\n", "\n"));
					collected = true;
					meshRenderer.enabled = false;
				}
			}
			else {
				GUI.Box(new Rect(0, 25, 200, 25), "Press 'F' to open Diary");
			}
		}
		
	}
}
