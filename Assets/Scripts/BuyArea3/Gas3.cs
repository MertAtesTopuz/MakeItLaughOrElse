using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gas3 : MonoBehaviour
{
  public GameObject GasserB;
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
