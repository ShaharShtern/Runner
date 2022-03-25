using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform player;
    Vector3 offset;
    void Start()
    {
        //create the offset that's between the player and the camera
        offset = player.position - transform.position;
    }

    void Update()
    {
        //move the camera together with the player with the offset
        transform.position = new Vector3 (transform.position.x, transform.position.y, player.position.z - offset.z);
    }
}
