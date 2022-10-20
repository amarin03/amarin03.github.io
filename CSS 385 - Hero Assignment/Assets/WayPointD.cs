using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointD : MonoBehaviour
{
    public int health = 100;
    public float alphaLevel = 1f;
    public static GameObject wayPointD;

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
    public void wayPointDamageD(int damage){
        health -= damage;

        if ( health <= 0){
            Destroy(gameObject); 
            Respawn();
              
        }
    }
    public void Respawn(){
        
        Vector3 position;
        wayPointD = Resources.Load<GameObject>("Prefabs/WayPointD");
        float x = Random.Range(-115, -85);
        float y = Random.Range(-85, -55);
        position = new Vector3(x, y, 0);
        GameObject prefab = Instantiate(wayPointD, position, wayPointD.transform.rotation) as GameObject;
    }
}
