using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinOrLose : MonoBehaviour
{
    [SerializeField] private Text resultText;

    private void Start()
    {

        if (GameSettings.PlayerDeath == true)
        {

            resultText.text = "DEFEAT";
        }
        else
        {

            resultText.text = "VICTORY";
        }
    }
}
