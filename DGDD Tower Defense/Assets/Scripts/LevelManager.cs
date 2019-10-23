using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    [Header("Currency Display")]
    public int currency;

    [Header("Essential Inputs")]
    public Text currencyText;
    public GameObject deck;
    public Transform trashArea;

    public Vector3 buildLocation;
    public bool hoveringOverNode;

    public GameObject[] card;
    public GameObject[] building;

    void Update()
    {
        currencyText.text = "Currency: " + currency;
    }

    public void ReplaceDeck()
    {
        int randomCardNumber = Random.Range(0, 2);
        Instantiate(card[randomCardNumber], deck.transform);

        Debug.Log("Building " + randomCardNumber);
    }
}
