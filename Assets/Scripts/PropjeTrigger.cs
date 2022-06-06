using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropjeTrigger : MonoBehaviour
{
    public Animator animator;
    public Animator letterAnimator;
    private bool enter = false;
    private bool open = false;
    
    public AudioSource audioOpen;
    public AudioSource audioClose;
   

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Player") {
        
            animator.SetBool("collision", true);
            enter = true;
        }
    }
    
    void OnTriggerExit2D (Collider2D other)
    {
        if (other.tag == "Player") {
        
            animator.SetBool("collision", false);
            enter = false;
        }
    }
    
    public void Update()
    {
        if (enter)
        {
            if (Input.GetKeyDown(KeyCode.E) && open == false)
            {
                letterAnimator.SetBool("IsOpen", true);
                open = true;
                audioOpen.Play();
            }
            else if (Input.GetKeyDown(KeyCode.E) && open == true)
            {
                letterAnimator.SetBool("IsOpen", false);
                open = false;
                audioClose.Play();
            }
        }  
        else if (Input.GetKeyDown(KeyCode.E) && open == true)
            {
                letterAnimator.SetBool("IsOpen", false);
                open = false;
                audioClose.Play();
            }
    }
}
