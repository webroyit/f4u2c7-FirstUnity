using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool isGameOver = false;

    public void EndGame()
    {
        if(isGameOver == false)
        {
            isGameOver = true;
            Debug.Log("Game Over");
        }
    }
}
