using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
public class PlayerDex : MonoBehaviour
{
    private List<String> diaries = new List<String>();
    private bool open = true;
    private string text = null;
    int index = 0;
    //index wird default auf 0 gesetzt;
    void Start()
    {
        diaries.Add("sdhfsuiodfhsdiufh\nsaiduhfuiwehfiuwehf\naiougheiuorgherg\n");
        diaries.Add("ioauehgiuerhgiuherg\nsaiduhfuiwehfiuwehf\nasuxucghsdduihf\n");
    }
    public void addPage(String input)
    {
        diaries.Add(input);
    }
    string getNext()
    {
        if (index + 1 <= diaries.Count)
        {
            index++;
        }
        return diaries.ElementAt(index);
    }
    string getPrev()
    {
        if(index-1 >= 0)
        {
            index--;
        }
        return diaries.ElementAt(index);
    }
    void OnGUI()
    {
        if (open)
        {
            Cursor.lockState = CursorLockMode.None;
            GUI.Box(new Rect(0, 0, 320, 455), "");
            GUI.Box(new Rect(0, 0, 320, 455), text);
            if (GUI.Button(new Rect(110, 350, 100, 100), "Exit"))
			{
               open = false;
               Cursor.lockState = CursorLockMode.Locked;
            }
		    if (GUI.Button(new Rect(215, 350, 100, 100), "Next"))
			{
               text = getNext();
			}
			if (GUI.Button(new Rect(5, 350, 100, 100), "Prev"))
			{
               text = getPrev();
			}
		}
    }
}
