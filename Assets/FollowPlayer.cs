using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Transform to access the player position, rotation and scale
    public Transform player;
    // Vector3 stores three floats
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        // Move the camera near the player
        // offset values are from the camera input
        transform.position = player.position + offset;
    }
}
