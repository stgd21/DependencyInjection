using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodEngine : IEngine
{
    public void StartEngine()
    {
        SetFire();
        Debug.Log("Wood engine started??");
    }

    private void SetFire()
    {
        Debug.Log("The engine has set on fire this isn't supposed to happen");
    }
}
