using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    Rigidbody rb;
    public float speedForce;
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
        rb.AddForce(0, 0, speedForce * Time.deltaTime);

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce*Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideForce*Time.deltaTime, 0, 0);
        }
    }
}
