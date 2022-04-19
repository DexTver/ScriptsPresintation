using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScale : MonoBehaviour
{
    public enum TypeButton
    {
        Run,
        Walk
    }

    public TypeButton typeOfBut = TypeButton.Run;
    public Button but;
    public Text txt;
    private RectTransform _rectTransform;
    private float scale;

    void Start()
    {
        scale = PlayerPrefs.GetFloat("scale") * 3;
        _rectTransform = but.GetComponent<RectTransform>();
        _rectTransform.sizeDelta = new Vector2(_rectTransform.sizeDelta.x * scale, _rectTransform.sizeDelta.y * scale);
        txt.fontSize = (int) Math.Round(Convert.ToDouble(txt.fontSize * scale), 0);
        if (typeOfBut == TypeButton.Run)
            _rectTransform.position =
                new Vector3(100 + _rectTransform.sizeDelta.x / 2, 100 + _rectTransform.sizeDelta.y * 2, 0);
        if (typeOfBut == TypeButton.Walk)
            _rectTransform.position =
                new Vector3(100 + _rectTransform.sizeDelta.x / 2, 100 + _rectTransform.sizeDelta.y / 2, 0);
    }
}