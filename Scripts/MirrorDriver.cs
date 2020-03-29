using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorDriver : IDriver
{
    private Bike m_Bike;

    public void Control(Bike bike)
    {
        m_Bike = bike;
        Debug.Log("This bike is controlled by a mirrored player!");
    }
}
