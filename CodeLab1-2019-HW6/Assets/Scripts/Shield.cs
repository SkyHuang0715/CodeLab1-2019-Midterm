using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Shield : MonoBehaviour
{
    public float duration = 10;
    
    

    public float damageMod = 0.5f;
    
 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer();
       
    }

    public virtual void Timer()
    {
        if (duration > 0)
        {
            duration -= Time.deltaTime;
            
        }
        else
        {
            print("destroy shield");
            Destroy(this);
        }
    }
    
    public virtual float ReduceDamage(float damage)
    {
        return damage = damageMod;
        
    }
}
