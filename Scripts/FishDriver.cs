using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishDriver : IDriver
{
    private Bike m_Bike;

    public void Control(Bike bike)
    {
        m_Bike = bike;
        Debug.Log("A fish is controlling the bike (uh-oh)");
    }
}
