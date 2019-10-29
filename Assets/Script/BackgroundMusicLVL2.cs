using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusicLVL2 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

        //audio components for music
        AudioSource AudioSourceMusic = GameObject.Find("MainCameraLVL2").GetComponent<AudioSource>();
        AudioClip AudioClipMusic = (AudioClip)Resources.Load("BackgroundMusic2");

        AudioSourceMusic.PlayOneShot(AudioClipMusic);
    }

}
