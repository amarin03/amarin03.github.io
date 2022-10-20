using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWP : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision){
        
        Waypoint wayPoint = collision.GetComponent<Waypoint>();

        if (collision.gameObject.name != "Hero"){
            wayPoint.wayPointDamage(25);
        } 
         Destroy(gameObject);  
    }
}
