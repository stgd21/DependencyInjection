using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NitroEngine : IEngine
{
    public void StartEngine()
    {
        OpenNitroValve();
        Debug.Log("Nitro Engine started");
    }

    private void OpenNitroValve()
    {
        Debug.Log("Nitro valve is open");
    }
}
