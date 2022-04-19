using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class Door : MonoBehaviour, IPointerClickHandler
{
    public enum open_type_ENUM
    {
        rot_to_open,
        move_to_open
    }

    public open_type_ENUM open_type;

    public enum door_axis_ENUM
    {
        X,
        Y,
        Z
    }

    public door_axis_ENUM door_axis = door_axis_ENUM.Z;
    public bool only_open;
    public bool can_be_opened_now;
    private bool is_open = false;
    public float open_speed = 150f;
    public float open_dist_or_angle = 100f;
    private float start_dist_or_angle;
    private bool open_close_ON;
    private bool cant_be_opened = false;

    private void Start()
    {
        if (open_type == open_type_ENUM.move_to_open)
        {
            switch (door_axis)
            {
                case door_axis_ENUM.X:
                    start_dist_or_angle = transform.localPosition.x;
                    break;
                case door_axis_ENUM.Y:
                    start_dist_or_angle = transform.localPosition.y;
                    break;
                case door_axis_ENUM.Z:
                    start_dist_or_angle = transform.localPosition.z;
                    break;
            }
        }
        else
        {
            switch (door_axis)
            {
                case door_axis_ENUM.X:
                    start_dist_or_angle = transform.localEulerAngles.x;
                    break;
                case door_axis_ENUM.Y:
                    start_dist_or_angle = transform.localEulerAngles.y;
                    break;
                case door_axis_ENUM.Z:
                    start_dist_or_angle = transform.localEulerAngles.z;
                    break;
            }
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!cant_be_opened) Open_close();
    }

    public void Open_close()
    {
        if (can_be_opened_now)
        {
            open_close_ON = true;
            //Debug.Log(open_close_ON);
            if (open_close_ON) open_close_ON = true;
            if (is_open) is_open = false;
            else
            {
                is_open = true;
                if (only_open)
                {
                    cant_be_opened = true;
                }
            }
        }
    }

    public void Update()
    {
        if (is_open)
        {
            if (open_type == open_type_ENUM.move_to_open) //движение
            {
                /*switch (door_axis)
                {
                    case door_axis_ENUM.X:
                        float posX = Mathf.MoveTowards(transform.localPosition.x,
                            start_dist_or_angle + open_dist_or_angle, open_speed * Time.deltaTime);
                        transform.localPosition =
                            new Vector3(posX, transform.localPosition.y, transform.localPosition.z);
                        if (transform.localPosition.x == start_dist_or_angle + open_dist_or_angle)
                            open_close_ON = false;
                        break;
                    case door_axis_ENUM.Y:
                        float posY = Mathf.MoveTowards(transform.localPosition.y,
                            start_dist_or_angle + open_dist_or_angle, open_speed * Time.deltaTime);
                        transform.localPosition =
                            new Vector3(transform.localPosition.x, posY, transform.localPosition.z);
                        if (transform.localPosition.y == start_dist_or_angle + open_dist_or_angle)
                            open_close_ON = false;
                        break;
                    case door_axis_ENUM.Z:
                        float posZ = Mathf.MoveTowards(transform.localPosition.z,
                            start_dist_or_angle + open_dist_or_angle, open_speed * Time.deltaTime);
                        transform.localPosition =
                            new Vector3(transform.localPosition.x, transform.localPosition.y, posZ);
                        if (transform.localPosition.z == start_dist_or_angle + open_dist_or_angle)
                            open_close_ON = false;
                        break;
                }*/
            }
            else // вращение
            {
                switch (door_axis)
                {
                    case door_axis_ENUM.X:
                        float angleX = Mathf.MoveTowardsAngle(transform.localEulerAngles.x,
                            start_dist_or_angle + open_dist_or_angle, open_speed * Time.deltaTime);
                        transform.localEulerAngles = new Vector3(angleX, 0, 0);
                        if (transform.localEulerAngles.x == start_dist_or_angle + open_dist_or_angle)
                            open_close_ON = false;
                        break;
                    case door_axis_ENUM.Y:
                        float angleY = Mathf.MoveTowardsAngle(transform.localEulerAngles.y,
                            start_dist_or_angle + open_dist_or_angle, open_speed * Time.deltaTime);
                        transform.localEulerAngles = new Vector3(0, angleY, 0);
                        if (transform.localEulerAngles.y == start_dist_or_angle + open_dist_or_angle)
                            open_close_ON = false;
                        break;
                    case door_axis_ENUM.Z:
                        float angleZ = Mathf.MoveTowardsAngle(transform.localEulerAngles.z,
                            start_dist_or_angle + open_dist_or_angle, open_speed * Time.deltaTime);
                        transform.localEulerAngles = new Vector3(0, 0, angleZ);
                        if (transform.localEulerAngles.z == start_dist_or_angle + open_dist_or_angle)
                            open_close_ON = false;
                        break;
                }
            }
        }
        else
        {
            if (open_type == open_type_ENUM.move_to_open) //движение
            {
                /*switch (door_axis)
                {
                    case door_axis_ENUM.X:
                        float posX = Mathf.MoveTowards(transform.localPosition.x,
                            start_dist_or_angle, open_speed * Time.deltaTime);
                        transform.localPosition =
                            new Vector3(posX, transform.localPosition.y, transform.localPosition.z);
                        if (transform.localPosition.x == start_dist_or_angle)
                            open_close_ON = false;
                        break;
                    case door_axis_ENUM.Y:
                        float posY = Mathf.MoveTowards(transform.localPosition.y,
                            start_dist_or_angle, open_speed * Time.deltaTime);
                        transform.localPosition =
                            new Vector3(transform.localPosition.x, posY, transform.localPosition.z);
                        if (transform.localPosition.y == start_dist_or_angle)
                            open_close_ON = false;
                        break;
                    case door_axis_ENUM.Z:
                        float posZ = Mathf.MoveTowards(transform.localPosition.z,
                            start_dist_or_angle, open_speed * Time.deltaTime);
                        transform.localPosition =
                            new Vector3(transform.localPosition.x, transform.localPosition.y, posZ);
                        if (transform.localPosition.z == start_dist_or_angle)
                            open_close_ON = false;
                        break;
                }*/
            }
            else // вращение
            {
                switch (door_axis)
                {
                    case door_axis_ENUM.X:
                        float angleX = Mathf.MoveTowardsAngle(transform.localEulerAngles.x,
                            start_dist_or_angle, open_speed * Time.deltaTime);
                        transform.localEulerAngles = new Vector3(angleX, 0, 0);
                        if (transform.localEulerAngles.x == start_dist_or_angle)
                            open_close_ON = false;
                        break;
                    case door_axis_ENUM.Y:
                        float angleY = Mathf.MoveTowardsAngle(transform.localEulerAngles.y,
                            start_dist_or_angle, open_speed * Time.deltaTime);
                        transform.localEulerAngles = new Vector3(0, angleY, 0);
                        if (transform.localEulerAngles.y == start_dist_or_angle)
                            open_close_ON = false;
                        break;
                    case door_axis_ENUM.Z:
                        float angleZ = Mathf.MoveTowardsAngle(transform.localEulerAngles.z,
                            start_dist_or_angle, open_speed * Time.deltaTime);
                        transform.localEulerAngles = new Vector3(0, 0, angleZ);
                        if (transform.localEulerAngles.z == start_dist_or_angle)
                            open_close_ON = false;
                        break;
                }
            }
        }
    }
}