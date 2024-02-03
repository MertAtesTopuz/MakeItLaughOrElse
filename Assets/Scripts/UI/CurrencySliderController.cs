using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class CurrencySliderController : MonoBehaviour
{
    public static CurrencySliderController instance;

    public TextMeshProUGUI currencyValueText;
    public int currencyValue = 0;
    public Slider currencySlider;

    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        currencySlider.value = currencyValue;
        currencyValueText.text = currencyValue.ToString();

        if (currencyValue >= currencySlider.maxValue)
        {
            currencyValue = Convert.ToInt32(currencySlider.maxValue);
        }
    }
}
