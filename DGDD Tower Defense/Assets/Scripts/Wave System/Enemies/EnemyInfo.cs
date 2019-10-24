using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "List of Enemies", menuName = "Enemy List")]
public class EnemyInfo : ScriptableObject
{
    public enum EnemyType { Trooper, Biker, Heavy, Bomber}

    public EnemyData trooper, biker, heavy, bomber;
    
  /// <summary>
  /// Searches through the database of enemies to return data of the enemy based on the enum given. 
  /// </summary>
  /// <param name="enemy">the EnemyType enum</param>
  /// <returns>The EnemyType</returns>
    public EnemyData FindEnemyData(EnemyType enemy)
    {
        switch (enemy)
        {
            case EnemyType.Biker:
                return biker;

            case EnemyType.Bomber:
                return bomber;

            case EnemyType.Trooper:
                return trooper;

            case EnemyType.Heavy:
                return heavy;

        }

        Debug.LogError("Invalid EnemyType.");
        return null; //If it's not in the list
    }

}
