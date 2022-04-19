using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Diagnostics;
using Debug = UnityEngine.Debug;

public class Consts : MonoBehaviour
{
    public static bool IsResume;
    public Scrollbar senseBar;
    public Text textSenseValue;
    public Scrollbar scaleBar;
    public Text textScaleValue;
    public static bool CanTeleport = true; // !!!
    void Update()
    {
        float senseBarValue = senseBar.value;
        if (Math.Abs(senseBarValue - PlayerPrefs.GetFloat("sensitivity")) > 0.0001)
        {
            textSenseValue.text = (senseBarValue * 10).ToString("0.00");
            PlayerPrefs.SetFloat("sensitivity", senseBarValue);
        }
        float scaleBarValue = scaleBar.value;
        if (Math.Abs(scaleBarValue - PlayerPrefs.GetFloat("scale")) > 0.0001)
        {
            textScaleValue.text = (scaleBarValue * 10).ToString("0.00");
            PlayerPrefs.SetFloat("scale", scaleBarValue);
        }
    }
    
    void Start()
    {
        if (!PlayerPrefs.HasKey("sensitivity")) PlayerPrefs.SetFloat("sensitivity", 0.1f);
        if (!PlayerPrefs.HasKey("scale")) PlayerPrefs.SetFloat("scale", 0.3f);
        textSenseValue.text = (PlayerPrefs.GetFloat("sensitivity") * 10).ToString("0.00");
        senseBar.value = PlayerPrefs.GetFloat("sensitivity");
        textScaleValue.text = (PlayerPrefs.GetFloat("scale") * 10).ToString("0.00");
        scaleBar.value = PlayerPrefs.GetFloat("scale");
        IsResume = PlayerPrefs.GetInt("isResume") == 1 ? true : false;
    }
}