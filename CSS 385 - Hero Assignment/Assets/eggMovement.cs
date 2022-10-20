using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eggMovement : MonoBehaviour
{
    public float speed = 40f;
    
    
    
    
    
    // Start is called before the first frame update
    void Update()
    {
        transform.position += transform.up * speed * Time.smoothDeltaTime;

        if (transform.position.x > 230 || transform.position.x < -230){
            Destroy(gameObject);
        }
        if (transform.position.y > 100 || transform.position.y < -100){
            Destroy(gameObject);
        }
    }
    
    
     private void OnTriggerEnter2D(Collider2D collision){
        
        Enemy enemy = collision.GetComponent<Enemy>();
        Waypoint wPA = collision.GetComponent<Waypoint>();
    
        if (collision.gameObject.name != "Hero"){
            
           enemy.Damage(25);
           wPA.wayPointDamage(25);
           
        } 
         Destroy(gameObject);  
    }
}
