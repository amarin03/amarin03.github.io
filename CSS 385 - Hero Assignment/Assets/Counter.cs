using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text eggCounter = null;
    public Text Movement = null;
    public bool enemyMovement = true;
    
    GameObject[] eggs;

    // Update is called once per frame
    void Update()
    {
        eggs = GameObject.FindGameObjectsWithTag("Egg");
        eggCounter.text = "EGG: OnScreen(" + eggs.Length.ToString() +")";

        if (Input.GetKeyDown("j")){
           enemyMovement = !enemyMovement;
        } 
        if(enemyMovement){
            Movement.text = "WAYPOINTS: (Sequence)";
            
        } else {
            Movement.text = "WAYPOINTS: (Random)";
            
        }
    }    
}
