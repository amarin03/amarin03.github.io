using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Weapon : MonoBehaviour {
        public Transform firePoint;
        public GameObject eggPrefab;

    // Update is called once per frame
    void Update(){
        if(Input.GetKeyDown("space")){
            shoot();
            
        }
    }
    public void shoot(){
        Instantiate(eggPrefab, firePoint.position, firePoint.rotation);
    }
}

