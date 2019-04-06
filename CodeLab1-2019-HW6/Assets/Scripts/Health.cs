using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health = 100f;

    public GameObject test;
    
    // Start is called before the first frame update
    void Start()
    {
        if (health <= 110 )
                {
                     test.AddComponent<Shield>();
                }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Damage(10);
        }

        
    }

    void Damage(float damageAmount)
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
