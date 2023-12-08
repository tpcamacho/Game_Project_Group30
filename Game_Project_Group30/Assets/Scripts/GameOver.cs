using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{
    public void playAgainButton()
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
