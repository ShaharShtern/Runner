using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    public float maxSpeed;
    public float sideSpeed;
    public float jumpForce;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
        //jump
        if (Input.GetKeyDown("w"))
        {
            //can only jump when at minimum Y
            if (transform.position.y == 0.625f)
            {
                rb.AddForce(0, jumpForce, 0);
            }
        }
    }
    private void FixedUpdate()
    {
        //gives forward movement
        transform.Translate(0, 0, speed);
        //increasing speed
        if (speed<maxSpeed)
        {
            speed += 0.001f;
        }
        
        //side movement
        if (Input.GetKey("a"))
        {
            transform.Translate(-sideSpeed, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(sideSpeed, 0, 0);
        }
        
        
    }
}
