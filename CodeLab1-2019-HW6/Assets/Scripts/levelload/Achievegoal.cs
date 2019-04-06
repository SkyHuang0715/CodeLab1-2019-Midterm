using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achievegoal : MonoBehaviour
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
            
                Debug.Log( "YOU WIN!"); //achieve goal to win
            }
            
        }
        
    }

