using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gas2 : MonoBehaviour
{
  public GameObject GasserA;
   void Start()
    {
        StartCoroutine(CurencyGain());
    }

    private IEnumerator CurencyGain()
    {
        yield return new WaitForSeconds(30);

        CurrencySliderController.instance.currencyValue += 100;

        StartCoroutine(CurencyGain());

    }
}
