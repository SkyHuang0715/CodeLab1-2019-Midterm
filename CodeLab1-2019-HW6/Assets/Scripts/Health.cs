using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float health = 100f;

    public GameObject test;

    public Text healthText;
    
     public bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        healthText.text = "Health " + health;
        
        if (health <= 0)
        {
            Destroy(gameObject);
            print("GAME OVER");
            Time.timeScale = 0;
            gameOver = true;
        }
        else
        {
            Time.timeScale = 1; 
        }
    }

    public void Damage(float damageAmount)
    {
        Shield armor = GetComponent<Shield>();

        if (armor != null)
        {
            print("Got a shield!!");
            damageAmount = armor.ReduceDamage(damageAmount);
            
        }
        else
        {
            print("Sorry, no shield for you :(");
        }

        health -= damageAmount;
        
    }
}
