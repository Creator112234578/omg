using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPush1 : MonoBehaviour
{
    bool ButtonPressed1 = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Button")
        {
            ButtonPressed1 = true;
        }
        
    }
    
}
