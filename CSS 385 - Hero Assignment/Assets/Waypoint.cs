using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    public int health = 100;
    public float alphaLevel = 1f;
    // Start is called before the first frame update
    void Start()
    {
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void wayPointDamage(int damage){
        health -= damage;
        if ( health <= 0){
            Destroy(gameObject);
            Respawn();
        }
    }
    public void Respawn(){
        
        // Vector3 position;
        //  enemyPrefab = Resources.Load<GameObject>("Prefabs/Enemy");
        // float x = Random.Range(-165, 165);
        // float y = Random.Range(-80, 80);
        // position = new Vector3(x, y, 0);
        // GameObject prefab = Instantiate(enemyPrefab, position, enemyPrefab.transform.rotation) as GameObject;
    }
    
}
