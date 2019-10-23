using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : DestructibleObject
{

    public override void Death()
    {
        Debug.Log("You lose lol");
        base.Death();
    }
}
