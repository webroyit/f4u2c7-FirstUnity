using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Collision to access it property
    void OnCollisionEnter(Collision collisionInfo)
    {
        // check to see what object it hits
       if(collisionInfo.collider.tag == "Obstacle")
       {
           Debug.Log("it is hited");
       }
    }
}
