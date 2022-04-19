using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OpenCloseWindow : MonoBehaviour, IPointerClickHandler
{

    public GameObject open;
    public GameObject close;
    public string id;
    public int count;
    
    
    public void OnPointerClick(PointerEventData eventData)
    {
        if (id == "")
        {
            open.SetActive(true);
            close.SetActive(false);
        }
        else
        {
            PlayerPrefs.SetInt(id, count);
            open.SetActive(true);
            close.SetActive(false);
        }
    }
}
