using UnityEngine;
using UnityEngine.SceneManagement;      // For changing or reloading scene

public class GameManager : MonoBehaviour
{
    bool isGameOver = false;
    public float delayAmount = 1f;
    public GameObject CompleteLevelUI;

    // Display the level complete message to the screen
    public void CompleteLevel(){
        // Show the popup UI to the screen
        CompleteLevelUI.SetActive(true);
    }

    // pubic to allow other files to access this function
    public void EndGame()
    {
        if(isGameOver == false)
        {
            isGameOver = true;
            //Debug.Log("Game Over");

            // Delay the time to restart the game
            // Take two arguments
            // Frist is name of the function
            // Second is the amount of time to delay
            Invoke("Restart", delayAmount);
        }
    }

    // Restart the game
    void Restart()
    {
        // Reload the current scene or stage
        // GetActiveScene().name to get the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
