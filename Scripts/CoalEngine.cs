using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoalEngine : IEngine
{
    public void StartEngine()
    {
        BurnCoal();
        Debug.Log("Coal Engine started");
    }

    private void BurnCoal()
    {
        Debug.Log("Destroying ozone with coal engine :)");
    }
}
