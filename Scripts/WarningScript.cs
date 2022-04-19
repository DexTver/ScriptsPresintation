using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarningScript : MonoBehaviour
{

    public GameObject FirstWarning;
    public GameObject SecondWarning;
    public GameObject ThirdWarning;
    public GameObject FourthWarning;
    private int ind;

    void Update()
    {
        if (PlayerPrefs.GetInt("WarningMessage") == 1)
        {
            PlayerPrefs.SetInt("WarningMessage", 0);
            ind = PlayerPrefs.GetInt("WarningIndex") + 1;
            switch (ind)
            {
                case 1:
                    FirstWarning.SetActive(true);
                    break;
                case 2:
                    SecondWarning.SetActive(true);
                    break;
                case 3:
                    ThirdWarning.SetActive(true);
                    break;
                case 4:
                    FourthWarning.SetActive(true);
                    break;
            }
            PlayerPrefs.SetInt("WarningIndex", ind);
        }
    }
}
