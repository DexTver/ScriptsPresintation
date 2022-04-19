using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultCases : MonoBehaviour
{
    public static Dictionary<string, int> data = new Dictionary<string, int>()
    {
        { "isResume", 0 },
        {"InternatPos", 3},
        {"CanTeleport", 0},
        {"WelcomeMessage", 1},
        {"WarningPaint", 1},
        {"WarningMessage", 0},
        {"WarningIndex", 0},
        {"Documents", 1},
        {"Hello", 0},
        {"HelloInd", 1},
        {"Clipboard", 0},
        {"Plan", 0},
        {"Books", 1},
        {"Backpack", 0},
        {"CanDragBag", 0},
        {"Day1", 0},
        {"Tray1", 0},
        {"Tray2", 0},
        {"MathTest", 0},
        {"GeographyTest", 0},
        {"Geography", 0},
        {"PhysicsTest", 0},
        {"Vase", 1},
        {"CanDragVase", 0},
        {"ActivateVase", 0},
        {"Day2", 0},
        {"OBZTest", 0},
        {"InformaticsTest", 0},
        {"EndHello", 0},
        {"Day3", 0}
    };

    public static void CreateDefault()
    {
        foreach (KeyValuePair<string, int> param in data)
        {
            PlayerPrefs.SetInt(param.Key, param.Value);
        }
    }
}
