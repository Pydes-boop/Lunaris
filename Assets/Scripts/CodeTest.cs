using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeTest : MonoBehaviour
{
	public string curPassword = "12345";
	public GameObject left;
	public GameObject right;
	public float opening = 3;
	public float speed = 1;
	private string input;
	private bool onTrigger;
	private bool doorOpen;
	private bool keypadScreen;
	public CameraControl playerCam;
	private void Start()
	{
		GameObject mainCam = GameObject.FindGameObjectWithTag("MainCamera");
		playerCam = mainCam.GetComponent<CameraControl>();
		playerCam.UILock = false;
	}

	void Update()
	{
		if (input == curPassword)
		{
			doorOpen = true;
			Cursor.lockState = CursorLockMode.Locked;
			//PLAYER CAMERA LOCK IN UI
			playerCam.UILock = false;
		}

		if (doorOpen)
		{
			if (left.transform.position.x < this.transform.position.x + opening)
			{
				left.transform.Translate(1 * speed * Time.deltaTime, 0f, 0f);
				right.transform.Translate(-1 * speed * Time.deltaTime, 0f, 0f);
			}
		}
	}

	void OnTriggerEnter(Collider other)
	{
		onTrigger = true;
	}

	void OnTriggerExit(Collider other)
	{
		onTrigger = false;
		keypadScreen = false;
		input = "";
		Cursor.lockState = CursorLockMode.Locked;
	}

	void OnGUI()
	{
		if (!doorOpen)
		{
			if (onTrigger)
			{
				GUI.Box(new Rect(0, 0, 200, 25), "Press 'E' to open keypad");

				if (Input.GetKeyDown(KeyCode.E))
				{
					keypadScreen = true;
					Cursor.lockState = CursorLockMode.None;
					//PLAYER CAMERA LOCK IN UI
					playerCam.UILock = true;
				}
			}

			if (keypadScreen)
			{
				GUI.Box(new Rect(0, 0, 320, 455), "");
				GUI.Box(new Rect(5, 5, 310, 25), input);

				if (GUI.Button(new Rect(5, 35, 100, 100), "1"))
				{
					input = input + "1";
				}

				if (GUI.Button(new Rect(110, 35, 100, 100), "2"))
				{
					input = input + "2";
				}

				if (GUI.Button(new Rect(215, 35, 100, 100), "3"))
				{
					input = input + "3";
				}

				if (GUI.Button(new Rect(5, 140, 100, 100), "4"))
				{
					input = input + "4";
				}

				if (GUI.Button(new Rect(110, 140, 100, 100), "5"))
				{
					input = input + "5";
				}

				if (GUI.Button(new Rect(215, 140, 100, 100), "6"))
				{
					input = input + "6";
				}

				if (GUI.Button(new Rect(5, 245, 100, 100), "7"))
				{
					input = input + "7";
				}

				if (GUI.Button(new Rect(110, 245, 100, 100), "8"))
				{
					input = input + "8";
				}

				if (GUI.Button(new Rect(215, 245, 100, 100), "9"))
				{
					input = input + "9";
				}

				if (GUI.Button(new Rect(110, 350, 100, 100), "0"))
				{
					input = input + "0";
				}
				if (GUI.Button(new Rect(215, 350, 100, 100), "ESC"))
				{
					keypadScreen = false;
					Cursor.lockState = CursorLockMode.Locked;
					//PLAYER CAMERA LOCK IN UI
					playerCam.UILock = false;
				}
				if (GUI.Button(new Rect(5, 350, 100, 100), "DEL"))
				{
					input = null;
				}
			}
		}
	}
}