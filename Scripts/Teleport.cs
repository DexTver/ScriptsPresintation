using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

public class Teleport : MonoBehaviour, IPointerClickHandler
{
    public GameObject tpObj;
    public Transform pos;
    public float rotX = 0f;
    public float rotY = 0f;
    public float rotZ = 0f;
    public int spawnPlace = 3;
    public string activate;
    public int value;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (PlayerPrefs.GetInt("CanTeleport") == 1)
        {
            tpObj.transform.position = pos.transform.position;
            tpObj.transform.rotation = Quaternion.Euler(new Vector3(rotX, rotY, rotZ));
            PlayerPrefs.SetInt("CanTeleport", 0);
            PlayerPrefs.SetInt("InternatPos", spawnPlace);
        }

        if (activate != "")
        {
            PlayerPrefs.SetInt(activate, value);
        }
    }
}