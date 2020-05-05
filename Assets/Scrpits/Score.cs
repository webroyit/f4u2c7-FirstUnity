using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Access the transform property from player object
    public Transform player;
    // Access the UI text
    public Text scoreText;
    
    // Update is called once per frame
    void Update()
    {
        // Player score based on the value of the z-axis
        // ToString() convert the float into string
        // "0" inside ToString() to format the score to a whole number
        scoreText.text = player.position.z.ToString("0");
    }
}
