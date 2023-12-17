using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    public Button startButton; // Reference to the Button component

    void Start()
    {
        // Adding a listener to the button click event 
        startButton.onClick.AddListener(StartGame);
    }

    // Method to handle the button click
    void StartGame()
    {
        Debug.Log("Game Started!!");
        // Add your game start logic here
    }
}
