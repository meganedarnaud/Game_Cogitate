using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float ClimbingSpeed = 6;

    //create a character controller to reference the controller script
    public CharacterController2D controller;
    
    //create animator
    public Animator animator;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;
    //bool climb = false;

    // Update is called once per frame
    void Update()
    {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
            animator.SetBool("IsClimbing", false);
        }

        

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;

        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;

        }

    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, ClimbingSpeed);
            animator.SetBool("IsClimbing", true);
        }
        else if (Input.GetButtonUp("Climb"))
        {
            animator.SetBool("IsClimbing", false);
        }
    }

        public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }

    public void OnCrouching(bool isCrouching)
    {
        animator.SetBool("IsCrouching", isCrouching);
    }

    void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
        animator.SetBool("IsClimbing", false);
    }
}
