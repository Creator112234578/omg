using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    float HInput, VInput;
    Quaternion Rot = Quaternion.identity;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HInput = Input.GetAxisRaw("Horizontal");
        VInput = Input.GetAxisRaw("Vertical");

        

        
        if (HInput > 0)
        {
            Rot.eulerAngles = new Vector3(0, 90, 0);
        }
        if (HInput < 0)
        {
            Rot.eulerAngles = new Vector3(0, -90, 0); 
        }
        if (VInput > 0)
        {
            Rot.eulerAngles = new Vector3(0, 0, 0);
        }
        if (VInput < 0)
        {
            Rot.eulerAngles = new Vector3(0, -180, 0); 
        }
        transform.rotation = Rot;

    }
}
