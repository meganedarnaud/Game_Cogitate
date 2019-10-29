using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel2 : MonoBehaviour
{



    public void startAScene(string scene)
    {
        SceneManager.LoadScene("Level2");
    }


}