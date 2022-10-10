using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text eggCounter = null;
    public Text enemyCounter = null;
    public Text enemyDestroyed = null;
    public Text heroCollision = null;
    private int destroyed = 0;
    
    GameObject[] enemies;
    GameObject[] eggs;

    // Start is called before the first frame update
    void Start()
    {
        enemyDestroyed.text = "Destroyed(" + destroyed +")";
    }

    // Update is called once per frame
    void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        eggs = GameObject.FindGameObjectsWithTag("Egg");
        enemyCounter.text = "Enemy: Count(" + enemies.Length.ToString() +")";
        eggCounter.text = "Egg Count(" + eggs.Length.ToString() +")";
        enemyDestroyed.text = "Destroyed(" + destroyed +")";
        DestroyedCount();
        

    }
    private void DestroyedCount() {
        for (int i = 0; i < enemies.Length; i++){
            destroyed++; 
        }
        
    }
    
        
}
