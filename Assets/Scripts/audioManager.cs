using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    public AudioSource startAudio;
    public AudioSource stopAudio;
    
    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Player") {
            
            stopAudio.Stop();
            startAudio.Play();
        }
    }
}
