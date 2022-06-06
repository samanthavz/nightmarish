using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesRespawn : MonoBehaviour
{
    float timeOut = 0f;
    
    [SerializeField] 
    private Transform respawnPoint;
    
    [SerializeField] 
    private Transform player;
    
    public static int health;
    
    void Update()
    {
        health = PlayerHealth.currentHealth;
        timeOut -= Time.deltaTime;
    }
    
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
                if (health > 0)
            {
                Debug.Log("health is still bigger than 0");
                player.transform.position = respawnPoint.transform.position;
            }
        }
    }
}
