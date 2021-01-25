using System;
using UnityEngine;
public class RightClickZoomSimple : MonoBehaviour
{
    [Tooltip("ZoomIn/Out = currentFov +/- Zoom")]
    public float Zoom = 10;
    [Tooltip("Currently unused")]
    public float smooth = 1;
    [Tooltip("ZoomIn/Out on MouseClick/MouseHold")]
    public bool MouseClick = true;

    private float _currentFov;
    private bool zoomedIn;
    private Camera main;

    void Start()
    {
        zoomedIn = false;
        main = GameObject.Find("Main Camera").GetComponent<Camera>();
        _currentFov = main.fieldOfView;
    }


    void Update()
    {
        if (MouseClick)
        {
            if (Input.GetMouseButtonDown(1))
                ChangeFOV();
        }
        else
        {
            if (Input.GetMouseButtonDown(1))
                ChangeFOV();
            if (Input.GetMouseButtonUp(1))
                ChangeFOV();
        }

    }

    void ChangeFOV()
    {
        //TODO: Smooth out Transition with Lerp and Time.DeltaTime
        if (!zoomedIn)
        {
            _currentFov -= Zoom;
            zoomedIn = true;
        }
        else
        {
            _currentFov += Zoom;
            zoomedIn = false;

        }

        main.fieldOfView = _currentFov;
    }
}
