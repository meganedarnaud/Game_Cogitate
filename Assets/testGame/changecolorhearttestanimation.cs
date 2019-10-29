using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changecolorhearttestanimation : MonoBehaviour
{

    //create animator
    public Animator animator;

    //health variables
    public static int maxHealth;
    public static int currentHealth;



    public void Start()
    {
        var totalkheart = GameObject.FindGameObjectsWithTag("HeartTotal");

        foreach (GameObject number in totalkheart)
        {
            number.GetComponent<Renderer>().material.color = Color.red;
        }
        maxHealth = 3;
        currentHealth = maxHealth;
    }




    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "PickUpHeart")
        {
            Destroy(collision.gameObject);

            if (currentHealth < maxHealth)
            {
                currentHealth++;
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
            SceneManager.LoadScene("EndGame");

        }
    }
}
