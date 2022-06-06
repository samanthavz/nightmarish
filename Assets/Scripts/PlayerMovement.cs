using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;

    public float runSpeed = 20f;

    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;
    
    public AudioSource audioSource;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        
        animator.SetFloat("walk", Mathf.Abs(horizontalMove));
        
        //add &&isGrounded
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("jump", true);
        }
        

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
            animator.SetBool("crouch", true);
        } else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
            animator.SetBool("crouch", false);
        }
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("menu");   
        }
    }
    
    public void OnLanding ()
    {
        animator.SetBool("jump", false);
        audioSource.Play();
    }
    
    
    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}
