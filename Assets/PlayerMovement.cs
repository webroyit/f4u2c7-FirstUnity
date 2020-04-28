﻿using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Access the Rigidbody component
    public Rigidbody rb;

    // float to work with decimal places
    public float forwardForce = 2000f;

    // Update is called once per frame
    // FixedUpdate for dealing with physics
    void FixedUpdate()
    {
        // Add force on the z-axis to move the cube
        // Time.deltaTime to fix the speed difference between the fast and slow pc
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
    }
}