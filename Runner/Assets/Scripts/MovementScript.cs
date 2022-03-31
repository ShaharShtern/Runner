using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    public float maxSpeed;
    public float sideForce;
    void Start()
    {
        //connect rigidbody to rb
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        //gives forward movement
        // rb.AddForce(0, 0, speedForce * Time.deltaTime);
        transform.Translate(0, 0, speed);
        if (speed<maxSpeed)
        {
            speed += 0.001f;
        }
        
        //side movement
        if (Input.GetKey("a"))
        {
            transform.Translate(-sideForce, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(sideForce, 0, 0);
        }
    }
}
