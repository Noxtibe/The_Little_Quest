using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public static bool GameIsOver = false;
    public GameObject gameOverUI;


    public void Retry()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Application.LoadLevel(Application.loadedLevel);
        Time.timeScale = 1f;
        GameIsOver = false;
    }

    public void LoadMenu()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        Application.Quit();
    }
}
