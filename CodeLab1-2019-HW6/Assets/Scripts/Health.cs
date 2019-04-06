using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float health = 100f;

    public GameObject test;

    public Text healthText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        healthText.text = "Health " + health;
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
