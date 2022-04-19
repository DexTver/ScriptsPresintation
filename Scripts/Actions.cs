using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actions : MonoBehaviour
{
    public static bool Ukr = false, Nor = false, Mex = false;
    void Start()
    {
        for (int i = 1; i < 10; ++i)
        {
            PlayerPrefs.SetInt(("HelloText" + i.ToString()), 0);
        }
    }
    
    void Update()
    {
        if (Ukr && Nor && Mex)
        {
            PlayerPrefs.SetInt("PhysicsTest", 1);
            Nor = Mex = Ukr = false;
        }

        if (PlayerPrefs.GetInt("Day3") == 1)
        {
            PlayerPrefs.SetInt("CanTeleport", 1);
            PlayerPrefs.SetInt("InternatPos", 3);
        }
    }
}
