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
    public int score;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
        //jump
        if (Input.GetKey("w"))
        {
            //can only jump when at minimum Y
            if (transform.position.y < 0.626f)
            {
                rb.velocity = new Vector3(0, jumpForce, 0);
            }
        }
        //score
        score = (int)Mathf.Round(transform.position.z * 100);
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
