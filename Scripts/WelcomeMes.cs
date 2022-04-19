using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WelcomeMes : MonoBehaviour
{
    public GameObject ToClose;
    public GameObject ToOpen;
    void Start()
    {
        if (PlayerPrefs.GetInt("WelcomeMessage") == 0)
        {
            ToOpen.SetActive(true);
            ToClose.SetActive(false);
        }
    }
    
}
