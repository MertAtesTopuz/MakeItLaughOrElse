using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Machines : MonoBehaviour
{
    public bool tikler, gas, baloons, mirror, jogger, popMachine;

    void Start()
    {
        if (tikler == true)
        {
            Tikler();
        }
        else if (gas == true)
        {
            Gas();
        }
        else if (baloons == true)
        {
            Baloons();
        }
        else if (mirror == true)
        {
            Mirror();
        }
        else if (jogger == true)
        {
            Jogger();
        }
        else if (popMachine == true)
        {
            PopMachine();
        }
        else
        {
            tikler = false;
            gas = false;
            baloons = false;
            mirror = false;
            jogger = false;
            popMachine = false;
        }
    }

    private void Tikler()
    {
        UIController.instance.maxCapasity += 10;
    }

    private void Gas()
    {
        StartCoroutine(CurencyGainGas());
    }

    private void Baloons()
    {
        UIController.instance.maxCapasity += 5;
    }

    private void Mirror()
    {
        SliderController.instance.sliderValue +=1;
    }

    private void Jogger()
    {
        SliderController.instance.sliderValue +=2;
    }

    private void PopMachine()
    {
        StartCoroutine(CurencyGainPopCorn());
    }

    private IEnumerator CurencyGainPopCorn()
    {
        yield return new WaitForSeconds(30);

        CurrencySliderController.instance.currencyValue += 50;

        StartCoroutine(CurencyGainPopCorn());

    }

    private IEnumerator CurencyGainGas()
    {
        yield return new WaitForSeconds(30);

        CurrencySliderController.instance.currencyValue += 100;

        StartCoroutine(CurencyGainGas());

    }
}
