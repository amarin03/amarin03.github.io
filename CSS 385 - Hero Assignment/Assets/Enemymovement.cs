using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemymovement : MonoBehaviour
{
    public GameObject [] wayPoint;
    private Quaternion enemyDirection;
    public float speed = 5f;
    private int currentPoint= 0;
    private float wayPointRadius = 5;
    public bool enemyMovement = true;
    
    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown("j")){
           enemyMovement = !enemyMovement;
        } 
        if(enemyMovement){
            sequentialMove(); 
        } else {
            randomMove();   
        }
    
    }
    public void sequentialMove(){
        speed = 10f;
        
        if (Vector3.Distance(wayPoint[currentPoint].transform.position, transform.position) < wayPointRadius){
            currentPoint++;
            if(currentPoint >= wayPoint.Length){
                currentPoint = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, wayPoint[currentPoint].transform.position, speed * Time.smoothDeltaTime);
        

        
        
    }
    public void randomMove(){
        
        if (Vector3.Distance(wayPoint[currentPoint].transform.position, transform.position) < wayPointRadius){
            currentPoint = Random.Range(0,wayPoint.Length);
            if(currentPoint >= wayPoint.Length){
                currentPoint = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, wayPoint[currentPoint].transform.position, speed * Time.smoothDeltaTime);
        
    }
}
