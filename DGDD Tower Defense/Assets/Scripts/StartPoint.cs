using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPoint : MonoBehaviour
{
    public GameObject tracer;

    private void Start()
    {
        InvokeRepeating("TracePath", 0.5f, 1f);
    }

    public void TracePath()
    {
        Instantiate(tracer, transform.position, Quaternion.identity); 
    }
}
