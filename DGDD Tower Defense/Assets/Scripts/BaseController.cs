using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The base/end point of the player. When destroyed, the player loses.  
/// </summary>

public class BaseController : DestructibleObject
{


    public override void Death()
    {
        Debug.Log("YOU LOSE LMAO");
    }
}
