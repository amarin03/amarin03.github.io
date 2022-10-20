using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointB : MonoBehaviour
{
    public int health = 100;
    public float alphaLevel = 1f;
    public static GameObject wayPointB;

    // Start is called before the first frame update
    void Start()
    {
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (health == 100){
            alphaLevel = 1f;
            GetComponent<SpriteRenderer>().color = new Color (1f,1f,1f,alphaLevel);
        }else if(health == 75){
            alphaLevel = .75f;
            GetComponent<SpriteRenderer>().color = new Color (1f,1f,1f,alphaLevel);
        } else if (health == 50){
            alphaLevel = .5f;
            GetComponent<SpriteRenderer>().color = new Color (1f,1f,1f,alphaLevel);
        } else {
            alphaLevel = .25f;
            GetComponent<SpriteRenderer>().color = new Color (1f,1f,1f,alphaLevel);
        }
       
    }
    public void wayPointDamageB(int damage){
        health -= damage;

        if ( health <= 0){
            Destroy(gameObject); 
            Respawn();
              
        }
    }
    public void Respawn(){
        
        Vector3 position;
        wayPointB = Resources.Load<GameObject>("Prefabs/WayPointB");
        float x = Random.Range(85, 115);
        float y = Random.Range(-85, -55);
        position = new Vector3(x, y, 0);
        GameObject prefab = Instantiate(wayPointB, position, wayPointB.transform.rotation) as GameObject;
    }
}

