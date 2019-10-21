using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretCard : MonoBehaviour
{
    private LevelManager theLevelManager;

    private int rarity = 1;
    public GameObject tower;
    public GameObject inventory;

    public void Buy()
    {
        if(theLevelManager.currency >= rarity)
        {

        }
    }
}
