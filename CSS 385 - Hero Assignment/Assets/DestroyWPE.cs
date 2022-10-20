using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWPE : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision){
        
        WayPointE wayPointE = collision.GetComponent<WayPointE>();
       
        if (collision.gameObject.name != "Hero"){
            
           wayPointE.wayPointDamageE(25);
           
        } 
        
        Destroy(gameObject);  
    }
}
