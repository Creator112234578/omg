using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLooking : MonoBehaviour
{
    public Transform player, cam;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cam.position = player.position + new Vector3(0, 2.91f, -5.97f);
    }
}
