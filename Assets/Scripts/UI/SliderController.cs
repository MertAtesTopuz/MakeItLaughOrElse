using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    public static SliderController instance;
    public Text valueText;
    public int sliderValue = 0;
    public Slider slider;

    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        slider.value = sliderValue;
    }

    public void OnSliderChange(float value)
    {
        valueText.text = value.ToString();
    }
 






}
