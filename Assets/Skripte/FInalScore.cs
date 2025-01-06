using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // Needed for Text

public class FInalScore : MonoBehaviour
{
    [SerializeField] private Text scoreText;

    void Start()
    {
        scoreText.text = "Your score: " + GameSettings.Score;
    }
}
