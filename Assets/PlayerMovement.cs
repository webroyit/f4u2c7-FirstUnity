using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Access the Rigidbody property
    public Rigidbody rb;

    // Update is called once per frame
    void Update()
    {
        // Move the cube
        rb.AddForce(0, 0, 200);
    }
}