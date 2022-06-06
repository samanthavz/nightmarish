using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingFloor : MonoBehaviour
{
    public Animator animator;
    public AudioSource audioSource;
    
    void OnCollisionEnter2D (Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Fall());
        }
    }
    
    IEnumerator Fall ()
    {   
        yield return new WaitForSeconds(0.5f);
        gameObject.GetComponent<PolygonCollider2D>().enabled = false;
        animator.SetBool("transparent", true);
        audioSource.Play();
    }

}
