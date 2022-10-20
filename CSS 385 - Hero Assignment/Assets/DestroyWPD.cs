using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWPD : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision){
    
        WayPointD wayPointD = collision.GetComponent<WayPointD>();
       
        if (collision.gameObject.name != "Hero"){
            
           wayPointD.wayPointDamageD(25);
           
        } 
        
        Destroy(gameObject);  
    }
}
