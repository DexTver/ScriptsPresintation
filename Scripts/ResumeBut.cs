using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResumeBut : MonoBehaviour
{
    void Update()
    {
        gameObject.SetActive(Consts.IsResume);
    }

    public void LoadScene(int number)
    {
        SceneManager.LoadScene (number);
    }
}
