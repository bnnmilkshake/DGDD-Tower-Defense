using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Tower : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private LevelManager theLevelManager;
    private BuildManager builder;

    void Start()
    {
        theLevelManager = FindObjectOfType<LevelManager>();
        builder = FindObjectOfType<BuildManager>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        //theLevelManager.towerSelected = true;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //theLevelManager.towerSelected = false;
    }

    public void Build(GameObject building)
    {
        builder.selectedBuilding = building;
        theLevelManager.towerSelected = gameObject;
    }
}
