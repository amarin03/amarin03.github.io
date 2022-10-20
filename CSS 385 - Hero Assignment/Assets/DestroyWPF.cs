using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWPF : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision){
        WayPointF wayPointF = collision.GetComponent<WayPointF>();

        if (collision.gameObject.name != "Hero"){

            wayPointF.wayPointDamageF(25);
        } 
        
        Destroy(gameObject);

    }
}
