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
        
    }
    
     private void OnTriggerEnter2D(Collider2D collision){
        
        Enemy enemy = collision.GetComponent<Enemy>();
        
        if (collision.gameObject.name != "Hero"){
            
           enemy.Damage(25);
           
        } 

         Destroy(gameObject);
         
    }

    void OnBecomeInvisible(){
        enabled = false;
        Destroy(gameObject);
        Debug.Log("egg destroyed");
    }
}
