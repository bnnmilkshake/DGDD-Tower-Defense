using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    [Header("Shooting")]
    public float fireRate = 1f;
    float nextFire; //The time before the player can shoot again
    public GameObject bullet;
    public Transform gunPoint;
    public float offset = 90;


    public Transform target;
    public float range;

    public Transform closestEnemy; 

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CheckEnemies", .5f, .25f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Hella buggy and rotation is off, needs a lot of fixing
        if(EnemyInRange() && closestEnemy != null)
        {
            //Calculate difference
            Vector3 difference = closestEnemy.position - transform.position;

            //Calculate rotation to face enemy
            float rotY = (Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg) + offset;
            transform.rotation = Quaternion.Euler(0f, rotY, 0f);
        }
    }

    void CheckEnemies()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy"); 

        float minDistance = Mathf.Infinity;
        closestEnemy = null; 

        foreach (GameObject enemy in enemies)
        {
            float dist = Vector3.Distance(enemy.transform.position, transform.position);

            if(dist <= minDistance)
            {
                minDistance = dist;
                closestEnemy = enemy.transform; 
            }

        }
        target = closestEnemy; 

        
    }

    bool EnemyInRange()
    {
        
        if (closestEnemy == null)
        {
            return false;  //If there are no enemies, return false (Prevent Null reference Exceptions)
        }

        float dist = Vector3.Distance(closestEnemy.transform.position, transform.position); //Calculate the distance between the closest enemy and current position

        if (dist <= range)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green; 
        Gizmos.DrawWireSphere(transform.position, range); 
    }
}
