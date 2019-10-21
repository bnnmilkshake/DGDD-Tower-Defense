using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    private Color startColor;

    [SerializeField] bool hasStructure; 

    //components
    BuildManager builder; 
    Renderer rend;
    LevelManager theLevelManager;

    

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
        builder = FindObjectOfType<BuildManager>();
        theLevelManager = FindObjectOfType<LevelManager>();
    }

    private void OnMouseEnter()
    {
        //Debug.Log("Hi");
        rend.material.color = hoverColor; 

       
    }

    private void OnMouseDown()
    {
        if (!hasStructure)
        {
            //Selection
            Vector3 buildLocation = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
            if(builder.selectedBuilding != null)
            {
                Instantiate(builder.selectedBuilding, buildLocation, Quaternion.identity);
                builder.selectedBuilding = null;
                Destroy(theLevelManager.towerSelected);
            }
        }
    }

    /*private void OnMouseUp()
    {
        if (theLevelManager.towerSelected)
        {
            if (!hasStructure)
            {
                //Selection
                Vector3 buildLocation = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
                Instantiate(theLevelManager.turret, buildLocation, Quaternion.identity);
            }
        }
    }*/

    private void OnMouseExit()
    {
        rend.material.color = startColor; 
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
