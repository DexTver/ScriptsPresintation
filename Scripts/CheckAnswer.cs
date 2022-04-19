using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class CheckAnswer : MonoBehaviour
{
    public InputField input;
    public string realAnswer;
    public Text returnText;

    public void Check()
    {
        if (input.text == "")
        {
            returnText.color = Color.black;
            returnText.text = "Нет ответа!";
        }
        else if (input.text.ToLower() == realAnswer)
        {
            returnText.color = Color.green;
            returnText.text = "Верно!";
            Redact(true);
        }
        else
        {
            returnText.color = Color.red;
            returnText.text = "Неверно!";
            Redact(false);
        }
    }

    private void Redact(bool count)
    {
        switch (realAnswer)
        {
            case "украина":
            {
                Actions.Ukr = count;
                break;
            }
            case "норвегия":
            {
                Actions.Nor = count;
                break;
            }
            case "мексика":
            {
                Actions.Mex = count;
                break;
            }
            case "48":
            {
                PlayerPrefs.SetInt("CanTeleport", 1);
                PlayerPrefs.SetInt("WarningPaint", 1);
                PlayerPrefs.SetInt("WarningIndex", 2);
                break;
            }
            case "1":
            {
                PlayerPrefs.SetInt("GeographyTest", 1);
                break;
            }
            case "противогаз":
            {
                PlayerPrefs.SetInt("InformaticsTest", 1);
                break;
            }
            case "6":
            {
                PlayerPrefs.SetInt("CanTeleport", 1);
                PlayerPrefs.SetInt("WarningPaint", 1);
                PlayerPrefs.SetInt("WarningIndex", 3);
                PlayerPrefs.SetInt("EndHello", 1);
                break;
            }
        }
    }
}
