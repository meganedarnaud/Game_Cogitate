using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Life : MonoBehaviour
{

    //create animator
    public Animator animator;

    //health variables
    public static int maxHealth;
    public static int currentHealth;



    public void Start()

    {

        var totalheart = GameObject.FindGameObjectsWithTag("HeartTotal");

        foreach (GameObject number in totalheart)
        {
            number.GetComponent<Renderer>().material.color = Color.red;
        }
        maxHealth = 3;
        currentHealth = maxHealth;
    }




    public void OnTriggerEnter2D(Collider2D collision)
    {
        //audio for picking up a potion
        AudioSource AudioSourcePotion = GameObject.Find("PotionSound").GetComponent<AudioSource>();
        AudioClip AudioClipPotion = (AudioClip)Resources.Load("Potion");

        if (collision.gameObject.tag == "PickUpHeart")
        {
            Destroy(collision.gameObject);

            if (currentHealth < maxHealth)
            {
                currentHealth++;
                AudioSourcePotion.PlayOneShot(AudioClipPotion);
            }

            GameObject.Find("Heart" + currentHealth).GetComponent<Renderer>().material.color = Color.red;

        }

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ennemies")
        {
            animator.SetBool("IsHurt", true);

            GameObject.Find("Heart" + currentHealth).GetComponent<Renderer>().material.color = Color.grey;
            if (currentHealth <= maxHealth && currentHealth != 0)
            {
                currentHealth--;
            }

            if (currentHealth == 0)
            {
                Debug.Log("YOU DIED!");
                SceneManager.LoadScene("EndGame");
            }

        }
        else
        {
            animator.SetBool("IsHurt", false);
        }


        if (collision.gameObject.tag == "Spike")
        {
            Debug.Log("YOU DIED!");

            //yield return new WaitForSeconds(2);
            SceneManager.LoadScene("EndGame");

        }
    }
}
