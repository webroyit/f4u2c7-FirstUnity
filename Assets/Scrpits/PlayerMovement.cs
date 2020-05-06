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
        
        // Listen for keyborad
        if(Input.GetKey("d"))
        {
            // Move right
            // By default ForceMode is Force is which add velocity to the object based on its mass
            // VelocityChange add velocity to the object but ignores its mass
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("a"))
        {
            // Move left
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // Check if the player fall off the edge
        if(rb.position.y < -1f)
        {
            // Reference an object from other classes
            // End the game
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}