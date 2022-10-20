using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWPC : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision){
        
        WayPointC wayPointC = collision.GetComponent<WayPointC>();
       
        
        if (collision.gameObject.name != "Hero"){
            
           wayPointC.wayPointDamageC(25);
           
        } 

        Destroy(gameObject);  
    }
}
