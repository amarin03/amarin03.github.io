using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroMovement : MonoBehaviour
{
    Vector3 p;
    public float speed = 20f;
    public float rotateSpeed = 2f;
    public bool mouseControl = true;
    public Text heroMode = null;
    public Text heroCollision = null;
    private int collisionCount = 0;
    
    
      
    // Update is called once per frame
    void Update(){   
        
        if (Input.GetKeyDown("m")){
           mouseControl = !mouseControl;
        } 

        if(mouseControl){
            MouseMovement();
            heroMode.text = "Hero Mode: Drive (Mouse)";
        } else {
            KeyboardMovement();
            heroMode.text = "Hero Mode: Drive (Key)";
        }

        heroCollision.text = "TouchedEnemy(" + collisionCount + ")";
    }

    private void MouseMovement() {
        p = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        p.z = 0f;
        transform.position = p;
    }

    private void KeyboardMovement(){

        transform.Translate(0f, .05f, 0f);
        

        if (Input.GetKey("w")){
            speed += Input.GetAxis("Vertical");
            transform.position += transform.up * (speed * Time.smoothDeltaTime);
        }
            
        if (Input.GetKey("s")){
            speed -= Input.GetAxis("Vertical");
            transform.position -= transform.up * (speed * Time.smoothDeltaTime);

        }
            
        if (Input.GetKey("a")){
            transform.Rotate(Vector3.forward, -10f * Input.GetAxis("Horizontal") * (rotateSpeed * Time.smoothDeltaTime)); 

        }
            
        if (Input.GetKey("d")){
            transform.Rotate(Vector3.forward, -10f * Input.GetAxis("Horizontal") * (rotateSpeed * Time.smoothDeltaTime)); 

        }
    }

    private void OnTriggerEnter2D(Collider2D collision){
        
        
        Enemy enemy = collision.GetComponent<Enemy>();
        
        if (collision.gameObject.name != "Hero"){

            collisionCount++;
            enemy.Damage(100);
           
           
        }
    }
}
