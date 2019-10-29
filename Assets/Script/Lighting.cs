using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighting : MonoBehaviour {

    Light lt;


    // Use this for initialization
    void Start () {

        lt = GetComponent<Light>();
    }
	
	// Update is called once per frame
	void Update () {

        lt.color -= (Color.white / 300.0f) * Time.deltaTime;
    }
}
