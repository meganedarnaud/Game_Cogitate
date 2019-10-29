using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusicLVL1 : MonoBehaviour {

    // Use this for initialization
    void Start () {

  //audio components for music
  AudioSource AudioSourceMusic = GameObject.Find("MainCameraLVL1").GetComponent<AudioSource>();
  AudioClip AudioClipMusic = (AudioClip)Resources.Load("BackgroundMusic1");

    AudioSourceMusic.PlayOneShot(AudioClipMusic);
    }
	
}
