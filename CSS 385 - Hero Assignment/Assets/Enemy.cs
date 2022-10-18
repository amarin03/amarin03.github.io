using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    
    public int healthBar = 100;
    public float alphaLevel = 1f;
    public static GameObject enemyPrefab;
    

    void Update(){

        if (healthBar == 100){
            alphaLevel = 1f;
            GetComponent<SpriteRenderer>().color = new Color (1,1,1,alphaLevel);
        }else if(healthBar == 75){
            alphaLevel = .75f;
            GetComponent<SpriteRenderer>().color = new Color (1,1,1,alphaLevel);
        } else if (healthBar == 50){
            alphaLevel = .5f;
            GetComponent<SpriteRenderer>().color = new Color (1,1,1,alphaLevel);
        } else {
            alphaLevel = .2f;
            GetComponent<SpriteRenderer>().color = new Color (1,1,1,alphaLevel);
        }
    }
    public void Damage(int damage){

        enemyPrefab = Resources.Load<GameObject>("Prefabs/Enemy");
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
