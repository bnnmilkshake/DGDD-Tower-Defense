using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public bool enemyProjectile;
    public int damage; 
    public float range;

    Rigidbody bulletRB;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, range);
        bulletRB = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
     if(other.tag == WhoIsEnemy())
        {
            other.SendMessageUpwards("TakeDamage", damage);

            Destroy(gameObject); 

        }   
    }


    string WhoIsEnemy()
    {
        if (enemyProjectile) 
        {
            return "Player";
        } else
        {
            return "Enemy";
        }
    }
    
}
