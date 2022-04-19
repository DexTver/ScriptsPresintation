using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

public class Sleep : MonoBehaviour, IPointerClickHandler
{
    public string day1;
    public string active1_1;
    public string active2_1;
    public string active3_1;
    public string active4_1;
    public string active5_1;
    public string Value1_1;
    public string Value2_1;
    public string day2;
    public string active1_2;
    public string active2_2;
    public string active3_2;
    public string active4_2;
    public string Value1_2;
    public string Value2_2;
    public string day3;
    public string Value1_3;
    public string Value2_3;
    public string Value3_3;
    public GameObject Sleeping;
    public GameObject Final;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (PlayerPrefs.GetInt(Value1_1) == 1 && PlayerPrefs.GetInt(Value2_1) == 1 && PlayerPrefs.GetInt(day1) == 0)
        {
            Sleeping.SetActive(true);
            PlayerPrefs.SetInt(active1_1, 1);
            PlayerPrefs.SetInt(active2_1, 1);
            PlayerPrefs.SetInt(active3_1, 1);
            PlayerPrefs.SetInt(active4_1, 1);
            PlayerPrefs.SetInt(active5_1, 1);
            PlayerPrefs.SetInt(day1, 1);
        }

        if (PlayerPrefs.GetInt(Value1_2) == 1 && PlayerPrefs.GetInt(Value2_2) == 8 && PlayerPrefs.GetInt(day2) == 0)
        {
            Sleeping.SetActive(true);
            PlayerPrefs.SetInt(active1_2, 1);
            PlayerPrefs.SetInt(active2_2, 1);
            PlayerPrefs.SetInt(active3_2, 0);
            PlayerPrefs.SetInt(day2, 1);
        }

        if (PlayerPrefs.GetInt(Value1_3) == 0 && PlayerPrefs.GetInt(Value2_3) == 0 &&
            PlayerPrefs.GetInt(Value3_3) == 10 && PlayerPrefs.GetInt(day3) == 0)
        {
            Final.SetActive(true);
            PlayerPrefs.SetInt(day3, 1);
        }
    }
}