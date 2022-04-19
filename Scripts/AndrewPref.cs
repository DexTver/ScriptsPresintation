using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;

public class AndrewPref : MonoBehaviour, IPointerClickHandler
{
    private int hello = 1;
    void Start()
    {
        hello = PlayerPrefs.GetInt("HelloInd");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (PlayerPrefs.GetInt("Hello") == 1)
        {
            if (hello < 5)
            {
                if (hello == 1)
                {
                    PlayerPrefs.SetInt("HelloText1", 1);
                    hello++;
                }
                else if (hello < 4)
                {
                    PlayerPrefs.SetInt(("HelloText" + (hello - 1).ToString()), 0);
                    PlayerPrefs.SetInt(("HelloText" + (hello).ToString()), 1);
                    hello++;
                }
                else
                {
                    PlayerPrefs.SetInt("HelloText3", 0);
                    PlayerPrefs.SetInt("Hello", 0);
                    PlayerPrefs.SetInt("Clipboard", 1);
                    PlayerPrefs.SetInt("HelloInd", 4);
                }
            }

            if (hello < 9 && hello > 5)
            {
                if (hello == 6)
                {
                    PlayerPrefs.SetInt("HelloText6", 1);
                    PlayerPrefs.SetInt("ActivateVase", 1);
                    hello++;
                }
                else if (hello < 8)
                {
                    PlayerPrefs.SetInt(("HelloText" + (hello - 1).ToString()), 0);
                    PlayerPrefs.SetInt(("HelloText" + (hello).ToString()), 1);
                    hello++;
                }
                else
                {
                    PlayerPrefs.SetInt("HelloText7", 0);
                    PlayerPrefs.SetInt("Hello", 0);
                    PlayerPrefs.SetInt("Books", 1);
                    PlayerPrefs.SetInt("HelloInd", 8);
                }
            }
        }

        if (PlayerPrefs.GetInt("EndHello") == 1)
        {
            if (hello == 8)
            {
                PlayerPrefs.SetInt("HelloText8", 1);
                hello++;
            }
            else if (hello < 10)
            {
                PlayerPrefs.SetInt(("HelloText" + (hello - 1).ToString()), 0);
                PlayerPrefs.SetInt(("HelloText" + (hello).ToString()), 1);
                hello++;
            }
            else
            {
                PlayerPrefs.SetInt("HelloText9", 0);
                PlayerPrefs.SetInt("Hello", 0);
                PlayerPrefs.SetInt("Tray1", 1);
                PlayerPrefs.SetInt("HelloInd", 10);
            }
        }

        if (PlayerPrefs.GetInt("Day1") == 1 && PlayerPrefs.GetInt("Tray1") == 0 && PlayerPrefs.GetInt("Tray2") == 0 &&
            PlayerPrefs.GetInt("Vase") == 1)
        {
            if (hello == 4)
            {
                PlayerPrefs.SetInt("HelloText4", 1);
                hello++;
            }
            else if (hello < 6)
            {
                PlayerPrefs.SetInt(("HelloText" + (hello - 1).ToString()), 0);
                PlayerPrefs.SetInt(("HelloText" + (hello).ToString()), 1);
                hello++;
            }
            else
            {
                PlayerPrefs.SetInt("HelloText5", 0);
                PlayerPrefs.SetInt("CanDragVase", 1);
                PlayerPrefs.SetInt("HelloInd", 6);
            }
        }
    }
}