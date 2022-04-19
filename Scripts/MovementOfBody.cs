using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class MovementOfBody : MonoBehaviour
{
    public Camera mCamera;
    private bool _walking, _running; //нажата ли кнопка
    private bool isSwiping, isMobile; //для поворота
    private Vector2 tapPosition, swipeDelta;
    public Transform firstPosition;
    public Transform secondPosition;
    public Transform thirdPosition;

    public void IsWalk(bool pushed)
    {
        _walking = pushed;
    }

    public void IsRun(bool pushed)
    {
        _running = pushed;
    }

    private bool IsActive()
    {
        bool act = _running || _walking;
        return act;
    }

    void Start()
    {
        isMobile = Application.isMobilePlatform;
        switch (PlayerPrefs.GetInt("InternatPos"))
        {
            case 1:
                transform.position = firstPosition.transform.position;
                transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
                break;
            case 2:
                transform.position = secondPosition.transform.position;
                transform.rotation = Quaternion.Euler(new Vector3(0, -90, 0));
                break;
            case 3:
                transform.position = thirdPosition.transform.position;
                transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
                break;
        }
    }

    void Update()
    {
        if (_running)
        {
            transform.position += transform.forward * 3f * Time.deltaTime;
        }
        else if (_walking)
        {
            transform.position += transform.forward * 1.4f * Time.deltaTime;
        }

        if (!isMobile)
        {
            if (Input.GetMouseButtonDown(0))
            {
                isSwiping = true;
                tapPosition = Input.mousePosition;
            }
            else if (Input.GetMouseButtonUp(0))
            {
                isSwiping = false;
            }

            if (isSwiping)
            {
                swipeDelta = (Vector2) Input.mousePosition - tapPosition;
                transform.Rotate(0f, -swipeDelta[0] * PlayerPrefs.GetFloat("sensitivity"), 0f);
                tapPosition = (Vector2) Input.mousePosition;
            }
        }
        else if (isMobile)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                isSwiping = true;
                tapPosition = Input.GetTouch(0).position;
            }
            else if (Input.GetTouch(0).phase == TouchPhase.Canceled ||
                     Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                isSwiping = false;
            }

            if (isSwiping && !(IsActive()))
                //if (isSwiping)
            {
                swipeDelta = Input.GetTouch(0).position - tapPosition;
                transform.Rotate(0f, -swipeDelta[0] * PlayerPrefs.GetFloat("sensitivity"), 0f);
                tapPosition = Input.GetTouch(0).position;
            }
        }
    }
}