using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackShield : Shield
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer();
        
    }
    
     public override float ReduceDamage(float damage)
        {
            return 0;
        }
}
