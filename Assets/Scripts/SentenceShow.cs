using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SentenceShow : MonoBehaviour
{
    public Animator Animator;
    private bool enter = false;
   

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Player") {
            Sentence();
        }
    }
    
    private void Sentence()
    {
        gameObject.GetComponent<DiaTrigger>().TriggerDialogue();
        enter = true;
        
    }
    
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && enter)
            {
                FindObjectOfType<DialogueManager>().DisplayNextSentence();
                enter = false;
            }
            
            else if (Input.GetKeyDown(KeyCode.Return) && enter)
            {
                FindObjectOfType<DialogueManager>().DisplayNextSentence();
                enter = false;
            }
    }
}
