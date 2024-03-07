using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Listens for the OnClick events for the main menu buttons
/// </summary>
public class MainMenu : MonoBehaviour
{
    /// <summary>
    /// Handles the on click event from the play button
    /// </summary>
    public void HandlePlayButtonOnClickEvent()
    {
        print("Hi, I've been clicked!!!!!!!!!!!!!!!!!!!!");

        SceneManager.LoadScene("Breakout");
    }
    
    /// <summary>
    /// Handles the on click event from the quit button
    /// </summary>
    public void HandleQuitButtonOnClickEvent()
    {
        Application.Quit();
    }
}
