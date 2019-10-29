using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keys : MonoBehaviour {




    public static int pickupkeyCount;

    public float maxSize;
    public float growFactor = 4;
    public float waitTime;


    public void Start()
    {
        var totalk = GameObject.FindGameObjectsWithTag("TotalKey");
        pickupkeyCount = 0;

        foreach (GameObject number in totalk)
        {
            number.GetComponent<Renderer>().material.color = Color.grey;
        }

    }



    public void OnTriggerEnter2D(Collider2D collision)
    {
        //audio for picking up a key
        AudioSource AudioSourceKey = GameObject.Find("KeySound").GetComponent<AudioSource>();
        AudioClip AudioClipKey = (AudioClip)Resources.Load("KeyPickUp");

        if (collision.gameObject.tag == "PickUpKey")
        {
            pickupkeyCount ++;
            Destroy(collision.gameObject);
            
            AudioSourceKey.PlayOneShot(AudioClipKey);


            GameObject.Find("TotalKey" + pickupkeyCount).GetComponent<Renderer>().material.color = Color.white;

            StartCoroutine(Scale());

         
        }

    }

    IEnumerator Scale
        ()
    {
        if (pickupkeyCount == 5)
        {
            //Destroy(GameObject.FindGameObjectWithTag("FrontDoor"));
            float timer = 0;

            while (true) // this could also be a condition indicating "alive or dead"
            {
                // we scale all axis, so they will have the same value, 
                // so we can work with a float instead of comparing vectors
                while (maxSize > GameObject.FindGameObjectWithTag("FrontDoorEmpty").transform.localScale.x)
                {
                    timer += Time.deltaTime;
                    GameObject.FindGameObjectWithTag("FrontDoorEmpty").transform.localScale += new Vector3(1, 0, 1) * Time.deltaTime * growFactor;
                    yield return null;
                }
                // reset the timer

                yield return new WaitForSeconds(waitTime);

                timer = 0;
                while (1 < GameObject.FindGameObjectWithTag("FrontDoorEmpty").transform.localScale.x)
                {
                    timer += Time.deltaTime;
                    GameObject.FindGameObjectWithTag("FrontDoorEmpty").transform.localScale -= new Vector3(1, 0, 0) * Time.deltaTime * growFactor;
                    GameObject.FindGameObjectWithTag("FrontDoorEmpty").transform.position -= new Vector3(-0.55f, 0, 0) * Time.deltaTime * growFactor;
                    yield return null;
                }

                timer = 0;
                yield return new WaitForSeconds(waitTime);

            }

        }



    }



}


    


