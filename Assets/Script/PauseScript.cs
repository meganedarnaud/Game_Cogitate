using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeButton : MonoBehaviour {

    public GameObject link;
    public bool GameIsPaused;
    public string empty = null;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Paused();
            }

        }
    }

    // Use this for initialization
    void Start () {
        Debug.Log("START");
       
       
    }
	

    void Paused()
    {
        Debug.Log("PAUSE");
        Time.timeScale = 0f;
        link.SetActive(true);
        GameIsPaused = true;

        //var items = GameObject.FindGameObjectsWithTag("HeartTotal");

        //foreach (var i in items)
        //{
        //    i.SetActive(false);
        //}

    }

    void Resume()
    {
        Debug.Log("RESUME");
        Time.timeScale = 1f;
        link.SetActive(false);
        GameIsPaused = false;
    }

}

