using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    //Bike controlled by plyaer
    public Bike m_PlayerBike;

    //AI controlled bikes
    public Bike m_AndroidBike;
    public Bike m_FishBike;
    public Bike m_MirrorBike;

    private void Awake()
    {
        //Human driver with jet engine bike
        IEngine jetEngine = new JetEngine();
        IDriver humanDriver = new HumanDriver();

        m_PlayerBike.SetEngine(jetEngine);
        m_PlayerBike.SetDriver(humanDriver);
        m_PlayerBike.StartEngine();

        //Android driver with nitro engine
        IEngine nitroEngine = new NitroEngine();
        IDriver androidDriver = new AndroidDriver();

        m_AndroidBike.SetEngine(nitroEngine);
        m_AndroidBike.SetDriver(androidDriver);
        m_AndroidBike.StartEngine();

        //Fish driver with wood engine
        IEngine woodEngine = new WoodEngine();
        IDriver fishDriver = new FishDriver();

        m_FishBike.SetEngine(woodEngine);
        m_FishBike.SetDriver(fishDriver);
        m_FishBike.StartEngine();

        //Mirror driver with coal engine
        IEngine coalEngine = new CoalEngine();
        IDriver mirrorDriver = new MirrorDriver();

        m_MirrorBike.SetEngine(coalEngine);
        m_MirrorBike.SetDriver(mirrorDriver);
        m_MirrorBike.StartEngine();
    }

    private void Update()
    {
        //for updating player-driven bike
        if (Input.GetKeyDown(KeyCode.A))
        {
            m_PlayerBike.TurnLeft();
            m_MirrorBike.TurnRight();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            m_PlayerBike.TurnRight();
            m_MirrorBike.TurnLeft();
        }
    }
}
