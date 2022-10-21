using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    
    public int healthBar = 100;
    public static GameObject enemyPrefab;
    
    
    void Update(){

        if (healthBar == 100){
            
            GetComponent<SpriteRenderer>().color = new Color (1f, 1f, 1f, 1f);
        }else if(healthBar == 75){
           
            GetComponent<SpriteRenderer>().color = new Color (1f, 1f, 1f, .75f);
        } else if (healthBar == 50){
            
            GetComponent<SpriteRenderer>().color = new Color (1f, 1f, 1f, .5f);
        } else {
            
            GetComponent<SpriteRenderer>().color = new Color (1f, 1f, 1f, .25f);
        }
    }
    public void Damage(int damage){

        healthBar -= damage;

        if (healthBar <= 0){
            Destroy(gameObject); 
            Respawn();
        }
    }
    public void Respawn(){
        
        Vector3 position;
        enemyPrefab = Resources.Load<GameObject>("Prefabs/Enemy");
        float x = Random.Range(-165, 165);
        float y = Random.Range(-80, 80);
        position = new Vector3(x, y, 0);
        GameObject prefab = Instantiate(enemyPrefab, position, enemyPrefab.transform.rotation) as GameObject;
    }
}
