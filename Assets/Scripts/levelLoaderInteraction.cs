using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelLoaderInteraction : MonoBehaviour
{
    public Animator animator;
    private bool enter = false;
    public string levelName;
    
    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Player") {
        
            animator.SetBool("entered", true);
            enter = true;
        }
    }
    
    void OnTriggerExit2D (Collider2D other)
    {
        if (other.tag == "Player") {
        
            animator.SetBool("entered", false);
            enter = false;
        }
    }
    
     public void Update()
    {
        if (enter)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene(levelName);
            }
        }
    }
}
