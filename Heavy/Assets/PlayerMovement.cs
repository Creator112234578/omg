using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    public float speed;

    public float Drag;

    [Header("Ground Check")]
    public float playerHeight;
    public LayerMask GroundUNow;
    bool grounded;

    public Transform orientation;
    float HInput;
    float VInput;
    Vector3 Direction;
    Rigidbody rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    private void Update()
    {
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, GroundUNow);
        MyInput();
        if (grounded)
        {
            rb.drag = Drag;
        }
        else
        {
            rb.drag = 0;
        }
        

    }
    private void FixedUpdate()
    {
        Movement();
    }

    private void MyInput()
    {
        HInput = Input.GetAxisRaw("Horizontal");
        VInput = Input.GetAxisRaw("Vertical");
    }
    private void Movement()
    {
        Direction = orientation.forward * VInput + orientation.right * HInput;

        rb.AddForce(Direction.normalized * speed * 10f, ForceMode.Force);
    }
}
