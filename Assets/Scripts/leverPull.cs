using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leverPull : MonoBehaviour
{
    
    public Animator animator;
    private bool enter = false;
    private bool pulled = false;
    public AudioSource audioSource;
    public GameObject hatch;
    
    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Player" && pulled == false) {
        
            animator.SetBool("interaction", true); 
            enter = true;
        }
    }
    
     void OnTriggerExit2D (Collider2D other)
    {
        if (other.tag == "Player" && pulled == false) {
        
            animator.SetBool("interaction", false);
            enter = false;
        }
    }
    
    public void Update()
    {
        if (enter)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                hatch.GetComponent<hatchOpen>().Open();
                pulled = true;
                enter = false;
                animator.SetBool("pull", true);
                audioSource.Play();
            }
            
        } 
    } 
}
