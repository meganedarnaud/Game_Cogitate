﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockStarterLVL2 : MonoBehaviour {

    public static bool rockTouch = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnTriggerEnter2D(Collider2D collision)
    {
        rockTouch = true;
        
    }
}
