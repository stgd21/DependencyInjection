using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetEngine : IEngine
{
    public void StartEngine()
    {
        ActivateJetStream();
        Debug.Log("Jet Engine started");
    }

    private void ActivateJetStream()
    {
        Debug.Log("Jet stream activated");
    }
}
