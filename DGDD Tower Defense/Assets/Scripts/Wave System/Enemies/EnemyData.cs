using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy", menuName = "Enemy Entry")]
public class EnemyData : ScriptableObject
{
    public GameObject enemyObj;
    public Sprite enemy;
    public string description; 


}
