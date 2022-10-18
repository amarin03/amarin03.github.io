using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public static GameObject enemyPrefab;
    
    

    void Start(){
        Spawn();
    }
    
    
    public void Spawn(){
        Vector3 position;
        enemyPrefab = Resources.Load<GameObject>("Prefabs/Enemy");
        int number = 10;
        
        
        for(int i = 0; i < number; i++){
            float x = Random.Range(-160, 160);
            float y = Random.Range(-80, 80);

            position = new Vector3(x, y, 0);
            Instantiate(enemyPrefab, position, enemyPrefab.transform.rotation);

        }
    }
   

    
    
}
