using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallInWater : MonoBehaviour
{
    [SerializeField] 
    private Transform respawnPoint;
    
    [SerializeField] 
    private Transform player;
    
    public HealthBar healthBar;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            deth();
        }
    }
    
    void deth()
    {   
        player.transform.position = respawnPoint.transform.position;
    }
}
