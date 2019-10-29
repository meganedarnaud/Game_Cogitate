using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2LVL1Script : MonoBehaviour {

    List<GameObject> prefabList = new List<GameObject>();

    public GameObject Prefab1;

    public bool alreadyOnce = false;

    public void Update()
    {

        if (RockStarterLVL1.rockTouch == true && alreadyOnce == false) {
            
            Instantiate(Prefab1, transform.position, transform.rotation);
            alreadyOnce = true;
        }
    }
}
