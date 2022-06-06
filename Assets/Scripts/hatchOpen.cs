using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hatchOpen : MonoBehaviour
{
    public Animator animator;
    
    public void Open(){
        
        Debug.Log("hatch is open");
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        animator.SetBool("opened", true);
    }
}
