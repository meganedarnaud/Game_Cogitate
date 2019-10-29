using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterDoor2 : MonoBehaviour
{

    public static bool backDoorTouch = false;
    // Use this for initialization
    void Start()
    {
        backDoorTouch = false;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {

        backDoorTouch = true;
    }

}
