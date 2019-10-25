using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor; 

[System.Serializable]
public class Wave
{
    [HideInInspector]
    public string unityName; 
    public float spawnTime;
    public Horde[] groupsOfEnemies;

    [HideInInspector] public int currentHorde; //The wave progress 
    

    
    
}
