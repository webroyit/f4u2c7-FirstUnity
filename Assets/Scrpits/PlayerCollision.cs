using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    // Collision to access it property
    void OnCollisionEnter(Collision collisionInfo)
    {
        // Check to see what object it hits
        // It is better use tag instead of name to apply the logic to all object with the name of the tag
       if(collisionInfo.collider.tag == "Obstacle")
       {
           // Display the player movement if it hitted the obstacle
           movement.enabled = false;
           // Reference an object from other classes
           FindObjectOfType<GameManager>().EndGame();
           
       }
    }
}
