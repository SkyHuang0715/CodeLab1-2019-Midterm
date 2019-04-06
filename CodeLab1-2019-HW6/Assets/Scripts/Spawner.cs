using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class Spawner : MonoBehaviour {

    private bool gameOver;
    // Use this for initialization
    void Start () {
        gameOver = false;
        //Spawn();
        InvokeRepeating("SpawnEnemy",1,2f);
        InvokeRepeating("SpawnShield",3,30f);
        InvokeRepeating("SpawnAttack",10,15f);
        InvokeRepeating("SpawnAbsorb",20,60f);
    }
	
    // Update is called once per frame
    void Update () {
	
        if (!gameOver)
        {
            //Spawn();
			
			
        }
    }

    void SpawnEnemy ()
    {
        GameObject newEnemy = Instantiate(Resources.Load<GameObject>("Prefab/enemy"));
        newEnemy.transform.position = new Vector2(Random.Range(-8,7), Random.Range(-8,9));


    }

    void SpawnShield()
    {
        GameObject newShield = Instantiate(Resources.Load<GameObject>("Prefab/shield"));
        newShield.transform.position = new Vector2(Random.Range(-8,7), Random.Range(-8,9));
    }
    
    void SpawnAttack()
    {
        GameObject newShield = Instantiate(Resources.Load<GameObject>("Prefab/attack"));
        newShield.transform.position = new Vector2(Random.Range(-8,7), Random.Range(-8,9));
    }
    
    void SpawnAbsorb()
    {
        GameObject newShield = Instantiate(Resources.Load<GameObject>("Prefab/absorb"));
        newShield.transform.position = new Vector2(Random.Range(-8,7), Random.Range(-8,9));
    }
}
