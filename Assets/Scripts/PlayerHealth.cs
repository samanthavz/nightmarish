using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    //helth
    public int maxHealth = 4;
    public static int currentHealth;
    
    public HealthBar healthBar;
    public AudioSource audioSource;
    
//    //force
//    private PointEffector2D force;
//    public GameObject enemy;
    float timeOut = 0f;

    //deth
    
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    
    // Start is called before the first frame update
    void Start()
    {
        //health stuff
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        respawnPoint.transform.position = player.transform.position;
        
        //push force stuff
//        enemy = GameObject.Find("enemy");
//        force = enemy.GetComponent<PointEffector2D>();
//        force.enabled = false;
        
    }
    
    void Update()
    {
        timeOut -= Time.deltaTime;
    }
    
    void TakeDamage(int damage)
    {
    
        currentHealth -= damage;
    
        healthBar.SetHealth(currentHealth);
        
        audioSource.Play();
        
        if (currentHealth == 0)
        {
            deth();
        }
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy" && timeOut <= 0) 
        {
            TakeDamage(1);
//            force.enabled = true;
            timeOut = 1f;
            StartCoroutine(SomeCoroutine());
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "checkpoint") 
        {
            Debug.Log("checkpoint!");
            respawnPoint.transform.position = player.transform.position;
        }
    }
    
    private IEnumerator SomeCoroutine()
    {
        yield return new WaitForSeconds(0.5f);
//        force.enabled = false;
    }
    
    void deth()
    {   
        currentHealth = 4;
        healthBar.SetHealth(currentHealth);
        player.transform.position = respawnPoint.transform.position;  
    }
}
