using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{

    public GameObject PauseMenuCanvasObject;
    public bool GameIsPaused;
    public string empty = null;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    public void PauseTheGame()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused==true)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    void Pause()
    {
        Time.timeScale = 0f;
        PauseMenuCanvasObject.SetActive(true);
        GameIsPaused = true;
    }

    void Resume()
    {
        Time.timeScale = 1f;
        PauseMenuCanvasObject.SetActive(false);
        GameIsPaused = false;
    }

}

