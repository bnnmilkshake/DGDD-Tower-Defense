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

    private void OnMouseEnter() //When mouse has just hovered the node
    {
        rend.material.color = hoverColor;
        theLevelManager.hoveringOverNode = true;
    }

    private void OnMouseOver() //When mouse is currently hovering over the node
    {
        theLevelManager.buildLocation = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
    }

    private void OnMouseExit() //When mouse has moved away from the node
    {
        rend.material.color = startColor;
        theLevelManager.hoveringOverNode = false;
    }
}
