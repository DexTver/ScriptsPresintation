using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ChangeScene(int number)
    {
        SceneManager.LoadScene (number);
    }
    
    public void ClearChangeScene(int number)
    {
        DefaultCases.CreateDefault();
        PlayerPrefs.SetInt("isResume", 1);
        SceneManager.LoadScene (number);
    }
    
    public void Exit(bool doYouWant)
    {
        if (doYouWant)
        {
            Debug.Log("Trying of exit");
            Application.Quit ();
        }
    }
}