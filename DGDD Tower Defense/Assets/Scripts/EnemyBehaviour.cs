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

    // Start is called before the first frame update
    void Start()
    {

        agent = GetComponent<NavMeshAgent>();
        endPt = GameObject.FindGameObjectWithTag("Base");
        agent.SetDestination(endPt.transform.position);
       
    }

    private void LateUpdate()
    {
        agent.SetDestination(endPt.transform.position);
    }

    private void OnDestroy()
    {
        FindObjectOfType<LevelManager>().currency += currencyToGive;
    }
}
