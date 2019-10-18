using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructibleObject : MonoBehaviour
{

    public int health; 
    
    public virtual void Start()
    {
        //TODO: Healthbar controls
    }
    // Update is called once per frame
    public virtual void Update()
    {
        
    }

    /// <param name="damage"> The damage this object will take from calling this function</param>
    public virtual void TakeDamage(int damage)
    {
        health -= damage;

        if(health <= 0)
        {
            Death(); 
        }

    }

    public virtual void Death()
    {
        Destroy(gameObject);
    }


}
