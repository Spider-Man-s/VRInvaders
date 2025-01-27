using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowHP : MonoBehaviour
{

    [SerializeField] private Slider mySlider;
    [SerializeField] private Text myText;

    void Start()
    {
        mySlider.onValueChanged.AddListener(UpdateSliderText);
        UpdateSliderText(mySlider.value);
    }

    private void UpdateSliderText(float value)
    {
        float percentage = value * 100f;
        myText.text = Mathf.RoundToInt(percentage) + "%";
    }
}
