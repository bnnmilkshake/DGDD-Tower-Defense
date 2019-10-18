using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public GameObject selectedBuilding; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //On right click, whatever tower selected will be deselected. 
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Deselect");
            selectedBuilding = null; 
        }
    }


    /// <summary>
    /// Just a function to call when the 'buy' button is pressed. 
    /// When you left click on a node, the building is built. 
    /// </summary>
    /// <param name="building"> The prefab of the wall/ tower to be built</param>
    public void StartBuilding(GameObject building)
    {
        selectedBuilding = building; 
    }
}
