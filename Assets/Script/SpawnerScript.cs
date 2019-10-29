using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour {
    List<GameObject> prefabList = new List<GameObject>();

    public GameObject Prefab1;

    public int count = 1;


    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (Keys.pickupkeyCount == 5 && count == 1)
        {
            Instantiate(Prefab1, transform.position, transform.rotation);
            count++;
        }
        
    }
}
