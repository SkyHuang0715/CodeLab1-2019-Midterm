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
        InvokeRepeating("SpawnWhite",1,0.5f);
        InvokeRepeating("SpawnBlack",1,1);
        //InvokeRepeating("Spawn",3,3);
    }
	
    // Update is called once per frame
    void Update () {
	
        if (!gameOver)
        {
            //Spawn();
			
			
        }
    }

    void SpawnWhite ()
    {
        GameObject newPrize = Instantiate(Resources.Load<GameObject>("Prefab/Prize"));
        newPrize.transform.position = new Vector2(Random.Range(-8,8), 8);





    }

    void SpawnBlack()
    {
        GameObject newBomb = Instantiate(Resources.Load<GameObject>("Prefab/Bomb"));
        newBomb.transform.position = new Vector2(Random.Range(-8,8), 8);
    }
	
	
	
}
