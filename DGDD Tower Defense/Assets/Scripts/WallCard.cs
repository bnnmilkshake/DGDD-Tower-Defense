using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCard : MonoBehaviour
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
            Instantiate(theLevelManager.wall, theLevelManager.inventory.transform);
            theLevelManager.currency -= rarity;
            Destroy(gameObject);
        }
    }
}
