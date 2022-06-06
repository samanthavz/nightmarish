using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    
    //force
    private PointEffector2D force;
    float timeOut = 0f;
    
    [Range(0.0f, 1.0f)]
    public float yForce;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
        //push force stuff
        force = gameObject.GetComponent<PointEffector2D>();
        force.enabled = false;
        
    }
    
    void Update()
    {
        timeOut -= Time.deltaTime;
        
    }
    
    
    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player" && timeOut <= 0) 
        {
//            force.enabled = true;
            timeOut = 0.5f;
            StartCoroutine(SomeCoroutine());
            Vector2 knockbackVector = other.gameObject.transform.position -  gameObject.transform.position;
            knockbackVector.y = ( knockbackVector.y > yForce) ? yForce : knockbackVector.y;
            
            other.gameObject.GetComponent<Rigidbody2D>().AddForce(knockbackVector * 3000f);
            
        }
    }
    
    private IEnumerator SomeCoroutine()
    {
        yield return new WaitForSeconds(0.3f);
        force.enabled = false;
    }
    
}
