using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public int currency;
    public Text currencyText;
    public GameObject inventory;
    public GameObject buySlots;

    public GameObject tower;
    public GameObject wall;

    public GameObject towerSelected;

    public GameObject turret;

    public GameObject[] cards;

    public int numberOfTowers;
    public int numberOfWalls;

    void Update()
    {
        currencyText.text = "Currency: " + currency;

        GameObject[] towers = GameObject.FindGameObjectsWithTag("Tower");
        numberOfTowers = towers.Length;
        GameObject[] walls = GameObject.FindGameObjectsWithTag("Wall");
        numberOfWalls = walls.Length;
    }

    public void Reroll()
    {
        if(currency >= 2)
        {
            foreach (Transform child in buySlots.transform)
            {
                Destroy(child.gameObject);
            }

            for (int i = 0; i < 5; i++)
            {
                int randomCard = Random.Range(0, 2);

                Instantiate(cards[randomCard], buySlots.transform);
            }

            currency -= 2;
        }
    }
}
