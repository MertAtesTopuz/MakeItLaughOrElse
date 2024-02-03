using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopMachine3 : MonoBehaviour
{
    public GameObject PopcornMachineB;

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
