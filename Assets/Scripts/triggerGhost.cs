using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerGhost : MonoBehaviour
{
    [SerializeField] GameObject wall;
    [SerializeField] Animator animator;
     public AudioSource audioSource;
    
    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Player") {
            animator.SetBool("invisible", true);
            wall.GetComponent<BoxCollider2D>().enabled = false;
            audioSource.Play();
            AstarPath.active.Scan();
            
        }
    }
}
