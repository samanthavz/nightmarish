using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatRide : MonoBehaviour
{
    public Animator animator;
    public AudioSource cameraAudio;
    public AudioSource audioSource;
    
    void OnCollisionEnter2D (Collision2D other) 
    {
        if (other.gameObject.CompareTag("Player"))
        {
            animator.SetBool("move", true);
            other.collider.transform.SetParent(transform);
            animator.SetBool("triggered", true);
            cameraAudio.Stop();
            audioSource.Play();
        }
    }
    
    void OnCollisionExit2D (Collision2D other) 
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.collider.transform.SetParent(null);
        }
    }
}
