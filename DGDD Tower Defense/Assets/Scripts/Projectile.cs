using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [Header("Projectile")]
    public bool enemyProjectile;
    public int damage; 
    public float range;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, range);
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
     if(other.tag == "Enemy")
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
