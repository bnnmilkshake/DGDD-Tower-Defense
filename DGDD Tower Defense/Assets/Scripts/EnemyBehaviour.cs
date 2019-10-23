using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehaviour : DestructibleObject
{
    NavMeshAgent agent;
    GameObject endPt;

    [Header("Essentials")]
    public int currencyToGive;

    //public Transform target;

    [Header("Turret Varibles")]
    public float range;
    public Transform target;
    public Transform partToRotate;
    public float rotateSpeed;

    [Header("Bullet Variables")]
    public float timeBefFire;
    bool hasShot = false;
    public GameObject bullet;
    public Transform firePoint;
    public float bulletSpeed;


    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();
        agent = GetComponent<NavMeshAgent>();
        endPt = GameObject.FindGameObjectWithTag("Base");
        agent.SetDestination(endPt.transform.position);

        InvokeRepeating("FindTurrets", 0, 0.1f);
    }

    private void LateUpdate()
    {
        agent.SetDestination(endPt.transform.position);
    }

    private void OnDestroy()
    {
        FindObjectOfType<LevelManager>().currency += currencyToGive;
    }

    void FindTurrets()
    {
        GameObject[] turrets = GameObject.FindGameObjectsWithTag("Tower"); //finds all turrets in the scene

        float shortestDist = Mathf.Infinity;
        GameObject nearestTurret = null;

        foreach(GameObject turret in turrets)
        {
            float distToTurret = Vector3.Distance(transform.position, turret.transform.position); //find distance from enemy to turret positions
            if (distToTurret < shortestDist) //if dist is less than shorter dist, hence it is in range
            {
                shortestDist = distToTurret; //shortest dist is same as dist
                nearestTurret = turret; //nearest target is now the turret being targeted
            }
        }

        if (nearestTurret != null && shortestDist <= range)
        {
            target = nearestTurret.transform;
        } else
        {
            target = null;
        }
    }

    public override void Update()
    {
        base.Update();

        //FaceTurret();

        Vector3 dir = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = Quaternion.Lerp(partToRotate.rotation, lookRotation, Time.deltaTime * rotateSpeed).eulerAngles;
        partToRotate.rotation = lookRotation; //Quaternion.EulerAngles(rotation);

        //Shoot();

        if (timeBefFire <= 0)
        {
            Shoot();
            timeBefFire = 0.5f;
        }

        timeBefFire -= Time.deltaTime;

        //timeBefFire -= Time.deltaTime;
        //Shoot();
    }

    void FaceTurret()
    {
        Vector3 dir = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = Quaternion.Lerp(partToRotate.rotation, lookRotation, Time.deltaTime * rotateSpeed).eulerAngles;
        partToRotate.rotation = lookRotation; //Quaternion.EulerAngles(rotation);

        //Shoot();

        if (timeBefFire <= 0)
        {
            Shoot();
            timeBefFire = 0.5f;
        }

        timeBefFire -= Time.deltaTime;

        //StartCoroutine(Shoot());
    }

    void Shoot()
    {
        /*if (hasShot == false)
        {
            GameObject bulletproj = Instantiate(bullet, firePoint.position, partToRotate.rotation);
            bulletproj.GetComponent<Rigidbody>().velocity = Vector3.forward * -bulletSpeed * Time.deltaTime;
            hasShot = true;
        }*/

         GameObject bulletproj = Instantiate(bullet, firePoint.position, firePoint.rotation);
         bulletproj.GetComponent<Rigidbody>().velocity = firePoint.transform.forward * 10;
         Debug.Log("Shoot");
    }

    /*IEnumerator Shoot()
    {
        if (hasShot == false)
        {
            GameObject bulletproj = Instantiate(bullet, transform.position, partToRotate.rotation);
            bulletproj.GetComponent<Rigidbody>().velocity = Vector3.forward * bulletSpeed * Time.deltaTime;
            hasShot = true;
        }

        yield return new WaitForSeconds(fireRate);

        hasShot = true;
        Debug.Log("Has Shoot");
    }*/

    //creates a range radius circle
    public void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, range);
        Gizmos.color = Color.red;
    }
}
