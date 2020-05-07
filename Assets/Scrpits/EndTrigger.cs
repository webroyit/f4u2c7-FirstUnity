using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    // To detect if something hit the trigger
    void OnTriggerEnter()
    {
        // called this function from GameManager class
        gameManager.CompleteLevel();
    }
}
