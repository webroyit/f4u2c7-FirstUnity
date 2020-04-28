using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Access the Rigidbody property
    public Rigidbody rb;

    // Update is called once per frame
    void Update()
    {
        // Move the cube
        // Time.deltaTime to fix the speed difference between the fast and slow pc
        rb.AddForce(0, 0, 2000 * Time.deltaTime);
    }
}