using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerATK : MonoBehaviour
{

    public GameObject myplayer;
    // Start is called before the first frame update
    void Start()
    {
        myplayer = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
    	
    			
    	
        //print("I GOT HIT");
        if (other.gameObject.CompareTag("Player"))//if the collider attached the prize
        {
            myplayer.AddComponent<AttackShield>();
            GameManager.instance.Score++;
            Destroy(gameObject); //Destroy the gameObject I am attached to
        }
    }
}

