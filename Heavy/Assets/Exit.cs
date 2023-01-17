using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public bool ButtonPressed = false;
    public bool ButtonPressed1 = false;
    public bool ButtonPressed2 = false;
    public bool ButtonPressed3 = false;
    public bool ButtonPressed4 = false;
    
    public GameObject ExitDoor;
    public GameObject LockedDoor;
    public GameObject WinTab;
    public GameObject Button;
    public GameObject ButtonSafe;
    void Start()
    {
        ExitDoor.SetActive(false);
        LockedDoor.SetActive(true);
        WinTab.SetActive(false);
        Button.SetActive(false);
        ButtonSafe.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (ButtonPressed == true & ButtonPressed1 == true & ButtonPressed2 == true & ButtonPressed3 == true & ButtonPressed4 == true)
        {
            ExitDoor.SetActive(true);
            LockedDoor.SetActive(false);
            
        }
        if (ButtonPressed2 == true & ButtonPressed3 == true & ButtonPressed == true)
        {
            Button.SetActive(true);
            ButtonSafe.SetActive(false);

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
        if (col.tag == "Button3")
        {
            ButtonPressed2 = true;
        }
        if (col.tag == "Button4")
        {
            ButtonPressed3 = true;
        }
        if (col.tag == "Button5")
        {
            ButtonPressed4 = true;
        }
        if (col.tag == "ExitDoor")
        {
            WinTab.SetActive(true);
        }

    }
    
}
