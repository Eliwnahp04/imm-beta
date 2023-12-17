using UnityEngine;
using UnityEngine.UI;

public class startButton : MonoBehaviour
{
    public Button StartButton; // Drag & drop the Button component from the Inspector to this field

    // Start is called before the first frame update
    void Start()
    {
        // Adding a listener to the button click event 
        StartButton.onClick.AddListener(StartGame);
    }

    // Method to handle the button click
    void StartGame()
    {
        Debug.Log("Game Started!!");
        // Add your game start logic here
    }
}
