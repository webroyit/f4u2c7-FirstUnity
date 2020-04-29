using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Transform to access the player position, rotation and scale
    public Transform player;

    // Update is called once per frame
    void Update()
    {
        // Print the value on the console
        Debug.Log(player.position);
    }
}
