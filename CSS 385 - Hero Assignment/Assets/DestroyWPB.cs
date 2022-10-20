using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWPB : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision){
        
        
        WayPointB wayPointB = collision.GetComponent<WayPointB>();
       
        
        if (collision.gameObject.name != "Hero"){
            
           wayPointB.wayPointDamageB(25);
           
        } 
         Destroy(gameObject);  
    }
}
