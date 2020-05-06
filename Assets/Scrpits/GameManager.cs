using UnityEngine;
using UnityEngine.SceneManagement;      // For changing or reloading scene

public class GameManager : MonoBehaviour
{
    bool isGameOver = false;

    // pubic to allow other files to access this function
    public void EndGame()
    {
        if(isGameOver == false)
        {
            isGameOver = true;
            Debug.Log("Game Over");
            Restart();
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
