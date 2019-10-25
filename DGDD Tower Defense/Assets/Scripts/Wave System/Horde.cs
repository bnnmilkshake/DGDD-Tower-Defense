using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Horde 
{
    [HideInInspector]
    public string inspectorName = "Enemy";
    public EnemyInfo.EnemyType enemyToSpawn;
    public int quantity;
   
}
