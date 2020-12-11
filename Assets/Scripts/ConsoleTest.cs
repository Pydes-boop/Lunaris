using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConsoleTest : MonoBehaviour
{
    public GameObject OpenPanel = null;
    public GameObject Console = null;
    private bool _isInsideTrigger = false;
    public Button yourButton;

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        Cursor.lockState = CursorLockMode.None;
        Console.SetActive(false);
    }
    void Start()
    {
        OpenPanel.SetActive(false);
        Console.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _isInsideTrigger = true;
            OpenPanel.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            _isInsideTrigger = false;
            OpenPanel.SetActive(false);
        }
    }

    private bool IsOpenPanelActive
    {
        get
        {
            return OpenPanel.activeInHierarchy;
        }
    }
    void openConsole()
    {
        Console.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void Update()
    {

        if (IsOpenPanelActive && _isInsideTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                OpenPanel.SetActive(false);
                openConsole();
            }
        }
    }
}
