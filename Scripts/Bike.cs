using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEngine
{
    void StartEngine();
}

public interface IDriver
{
    void Control(Bike bike);
}

public class Bike : MonoBehaviour
{
    private IEngine m_Engine;
    private IDriver m_Driver;

    //Setter injection
    public void SetEngine(IEngine engine)
    {
        m_Engine = engine;
    }

    //Setter injection
    public void SetDriver(IDriver driver)
    {
        m_Driver = driver;
    }

    public void StartEngine()
    {
        //Start the engine
        m_Engine.StartEngine();
        //Give control of bike to AI or player
        m_Driver.Control(this);
    }

    public void TurnLeft()
    {
        Debug.Log("Bike is turning left");
    }

    public void TurnRight()
    {
        Debug.Log("Bike is turning right");
    }
}
