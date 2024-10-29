using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class geoQuiz : MonoBehaviour
{
    public Text input;
    public Canvas canvas;
    public Text description;
    public InputField inputField;
    public Button button;
    public GameObject spawnBall;
    



    public void Check()
    {
        
        if (input.text == "21:00")
        {
           
        Image canvasImage = canvas.GetComponentInChildren<Image>();
        canvasImage.color= Color.green;
        description.text="\n Your answer is correct! \n\nGood work Explorer!\n Your reward is on the table.";
        description.color = Color.black;
        description.fontSize= 34;
        inputField.gameObject.SetActive(false);
        button.gameObject.SetActive(false);
        spawnBall.gameObject.SetActive(true);

        }
        else
        {
            Text t=button.GetComponentInChildren<Text>();
            Image img=button.GetComponentInChildren<Image>();
            img.color=Color.red;
            t.text="Oops, try again?";
        
        }
    }
}
