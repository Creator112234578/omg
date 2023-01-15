using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public bool ButtonPressed = false;
    public bool ButtonPressed1 = false;
    public GameObject ExitDoor;
    public GameObject LockedDoor;
    public GameObject WinTab;
    void Start()
    {
        ExitDoor.SetActive(false);
        LockedDoor.SetActive(true);
        WinTab.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (ButtonPressed == true & ButtonPressed1 == true)
        {
            ExitDoor.SetActive(true);
            LockedDoor.SetActive(false);
            
        }    
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Button1")
        {
            ButtonPressed = true;
        }
        if (col.tag == "Button2")
        {
            ButtonPressed1 = true;
        }
        if (col.tag == "ExitDoor")
        {
            WinTab.SetActive(true);
        }

    }
    
}
