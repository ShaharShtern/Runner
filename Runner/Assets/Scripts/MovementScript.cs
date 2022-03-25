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
        //side movement
        if (Input.GetKey("a"))
        {
            rb.velocity = new Vector3(-sideForce * Time.deltaTime, rb.velocity.y, rb.velocity.z);
        }
        if (Input.GetKey("d"))
        {
            rb.velocity = new Vector3 (sideForce*Time.deltaTime, rb.velocity.y, rb.velocity.z);
        }
    }
}
