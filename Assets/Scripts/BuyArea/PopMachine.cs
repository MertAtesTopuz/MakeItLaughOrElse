using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopMachine : MonoBehaviour
{
    public GameObject PopcornMachine;

    void Start()
    {
        StartCoroutine(CurencyGain());
    }

    private IEnumerator CurencyGain()
    {
        yield return new WaitForSeconds(30);

        CurrencySliderController.instance.currencyValue += 50;

        StartCoroutine(CurencyGain());

    }
}
