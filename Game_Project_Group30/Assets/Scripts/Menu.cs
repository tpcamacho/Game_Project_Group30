using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Start screen for game with play and quit button

public class Menu : MonoBehaviour
{
    public void startButton()
    {
        SceneManager.LoadScene(1);
    }

    /// <summary>
    /// Quits game
    /// </summary>
    public void quitButton()
    {
        Debug.Log("You closed the game");
        Application.Quit();
    }
}
