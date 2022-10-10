using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    // private Camera mTheCamera;
    // private Bounds mWorldBound;
    
    // private Vector2 mSpawnRegionMin;
    // private Vector2 mSpawnRegionMax;
    // private GameObject[] mEnemySystem;
    // private Vector2 EnemySpawnSystem;
    
    public GameObject enemyPrefab;
    
    

    void Start(){
        Spawn();
    }
    
    public void Spawn(){
        Vector3 position;
        int number = 10;
        
        
        for(int i = 0; i < number; i++){
            float x = Random.Range(-165, 165);
            float y = Random.Range(-80, 80);

            position = new Vector3(x, y, 0);
            Instantiate(enemyPrefab, position, enemyPrefab.transform.rotation);

        }
    }

    
    
}
