using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

public class SimplePref : MonoBehaviour, IPointerClickHandler
{
    public string active;
    public int count = 1;
    public bool destroy;
    public string selfname;
    public string condition;
    public int conditionValue;
    public int refactorConditionValue;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (condition == "")
        {
            PlayerPrefs.SetInt(active, count);
            if (destroy)
            {
                PlayerPrefs.SetInt(selfname, 0);
            }
        }
        else if (PlayerPrefs.GetInt(condition) == conditionValue)
        {
            PlayerPrefs.SetInt(active, count);
            if (destroy)
            {
                PlayerPrefs.SetInt(selfname, 0);
            }

            if (conditionValue != refactorConditionValue)
            {
                PlayerPrefs.SetInt(condition, refactorConditionValue);
            }
        }
    }
}
