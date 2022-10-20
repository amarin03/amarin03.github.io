using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideWaypoint : MonoBehaviour
{
    public bool notHidden = true;
    
    public GameObject waypoint;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("h")){
            notHidden = !notHidden;
        } 
        if(notHidden){
            appear();
        } else {
            disappear();
        }
        
    }
    private void appear(){
        waypoint.GetComponent<SpriteRenderer>().enabled = true;
    }
    private void disappear(){
        waypoint.GetComponent<SpriteRenderer>().enabled = false;
    }
    
}
