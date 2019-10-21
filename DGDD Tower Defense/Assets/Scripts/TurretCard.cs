﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretCard : MonoBehaviour
{
    private LevelManager theLevelManager;

    public int rarity = 1;

    void Start()
    {
        theLevelManager = FindObjectOfType<LevelManager>();
    }

    public void Buy()
    {
        if(theLevelManager.currency >= rarity)
        {
            Instantiate(theLevelManager.tower, theLevelManager.inventory.transform);
            theLevelManager.currency -= rarity;

            Destroy(gameObject);
        }
    }
}
