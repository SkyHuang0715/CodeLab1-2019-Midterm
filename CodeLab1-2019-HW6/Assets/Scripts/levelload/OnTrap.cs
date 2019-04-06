using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
    	
    			
    	
        //print("I GOT HIT");
        if (other.gameObject.CompareTag("Player"))//if the collider attached the prize
        {
            
            Destroy(gameObject); //Destroy the gameObject I am attached to
            GameObject player = GameObject.Find("Player(Clone)");

            if (player)
            {
                Destroy(player.gameObject); 
                Debug.Log(player + "is trapped"); //destroy player if on trap
            }
            
        }
        //GameControl.instance.Score += 10;
    }
}
