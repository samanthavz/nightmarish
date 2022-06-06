using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SidecharInteraction : MonoBehaviour
{

    public Animator animator;
    private bool enter = false;
    public AudioSource audioSource;

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Player") {
        
            animator.SetBool("interact", true);
            enter = true;
        }
    }
    
    void OnTriggerExit2D (Collider2D other)
    {
        if (other.tag == "Player") {
        
            animator.SetBool("interact", false);
            enter = false;
        }
    }
    
    public void Update()
    {
        if (enter)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                gameObject.GetComponent<DiaTrigger>().TriggerDialogue();
                audioSource.Play();
            }
            
            if (Input.GetKeyDown(KeyCode.Return))
            {
                FindObjectOfType<DialogueManager>().DisplayNextSentence();
            }
        } 
    } 
}
