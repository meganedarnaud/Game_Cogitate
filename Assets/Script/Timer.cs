using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public Text timerText;
    private float time = 300.0f;

    void Start()
    {
        StartCoundownTimer();
    }

    void Update()
    {
        if (time < 0.0f)
        {
            SceneManager.LoadScene("EndGame");
        }
    }

    void StartCoundownTimer()
    {
        if (timerText != null)
        {
            time = 300;
            timerText.text = "Time Left: 05.00";
            InvokeRepeating("UpdateTimer", 0.0f, 0.01667f);
        }
    }

    void UpdateTimer()
    {
        if (timerText != null)
        {
            time -= Time.deltaTime;
            string minutes = Mathf.Floor(time / 60).ToString("00");
            string seconds = (time % 60).ToString("00");
            string fraction = ((time * 100) % 100).ToString("000");
            timerText.text = "Time Left: " + minutes + ":" + seconds + ":" + fraction;
        }
    }

}
