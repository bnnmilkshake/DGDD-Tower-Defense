using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Card : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private LevelManager theLevelManager;
    private Node node;

    private Vector3 startPosition;

    private float distanceFromTrash;

    [Header("Essentials")]
    public int cost;
    public int cardNumber;

    void Start()
    {
        theLevelManager = FindObjectOfType<LevelManager>();
        node = FindObjectOfType<Node>();
    }

    public void OnBeginDrag(PointerEventData eventData) //Save the start position of the card before it is moved
    {
        startPosition = transform.position;
    }

    public void OnDrag(PointerEventData eventData) //Follows the position of the mouse cursor
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData) //Determine whether player is able to buy the card
    {
        distanceFromTrash = Vector3.Distance(theLevelManager.trashArea.position, transform.position);

        if(theLevelManager.currency >= cost)
        {
            if (distanceFromTrash >= 50) //If the card is not near the trash area
            {
                if (theLevelManager.hoveringOverNode)
                {
                    //Build the building card
                    Debug.Log("Building has been built, -" + cost + " Currency");
                    theLevelManager.currency -= cost;
                    Instantiate(theLevelManager.building[cardNumber], theLevelManager.buildLocation, Quaternion.identity);
                    theLevelManager.ReplaceDeck();
                    Destroy(gameObject);
                }
                else //If mouse is not hovering above any nodes
                {
                    transform.position = startPosition;
                }
            }
            else //If the card is hovering above the trash area
            {
                Debug.Log("Building has been trashed");
                theLevelManager.ReplaceDeck();
                theLevelManager.currency -= cost;
                Destroy(gameObject);
            }
        }
        else
        {
            transform.position = startPosition;
        }
    }
}
