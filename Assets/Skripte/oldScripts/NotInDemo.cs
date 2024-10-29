using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class NotInDemo : MonoBehaviour
{
   public Button button;


   public void Change(){

        Text t=button.GetComponentInChildren<Text>();
        Image img=button.GetComponentInChildren<Image>();
        img.color=Color.red;
        t.text="Not included in DEMO version :(";

   }
}
