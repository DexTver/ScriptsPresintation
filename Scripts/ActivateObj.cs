using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateObj : MonoBehaviour
{
    public GameObject obj;
    public string id;  // имя объекта в PlayerPrefs
    void Update()
    {
        if (PlayerPrefs.HasKey(id))
        {
            if (PlayerPrefs.GetInt(id) == 1)
            {
                obj.SetActive(true);
            }
            else
            {
                obj.SetActive(false);
            }
        }
    }
}
