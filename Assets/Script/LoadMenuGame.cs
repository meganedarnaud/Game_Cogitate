using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMenuGame : MonoBehaviour {

    public void startAScene(string scene)
    {
        SceneManager.LoadScene("MenuGame");
    }
}
