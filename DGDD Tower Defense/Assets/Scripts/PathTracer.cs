﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 

public class PathTracer : MonoBehaviour
{
    NavMeshAgent agent;
    GameObject endPt; 


    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        endPt = GameObject.FindGameObjectWithTag("Base");
        agent.SetDestination(endPt.transform.position);
        Destroy(gameObject, 1f); 
    }

    
}
