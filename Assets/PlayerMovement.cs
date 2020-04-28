using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Access the Rigidbody component
    public Rigidbody rb;

    // float to work with decimal places
    // f for float
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Update is called once per frame
    // FixedUpdate for dealing with physics
    void FixedUpdate()
    {
        // Add force on the z-axis to move the cube
        // Time.deltaTime to fix the speed difference between the fast and slow pc
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        
        // listen for keyborad
        if(Input.GetKey("d"))
        {
            // move right
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey("a"))
        {
            // move left
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}