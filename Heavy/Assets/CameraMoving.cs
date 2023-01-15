using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoving : MonoBehaviour
{
    public BoxCollider Boxx;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "Waater")
        {
            
        }
        if (col.tag == "Waaater")
        {

            
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "")
        {

        }
        if (col.tag == "Waaater")
        {


        }
    }
}
