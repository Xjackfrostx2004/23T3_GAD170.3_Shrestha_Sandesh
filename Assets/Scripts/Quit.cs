using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// This will send the player back to the Main Menu Scene.
/// </summary>
public class Quit : MonoBehaviour
{
    //If player presses ESC key, Load the Main Menu scene.

    // Update is called once per frame
    void Update()
    {//If player presses ESC key, Load the Main Menu scene.
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game");
        Application.Quit();
    }
}
