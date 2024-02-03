using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildControl : MonoBehaviour
{
    public GameObject[] buildings;
    public GameObject buildDeleater, buildArea;
    public bool tikler, gas, baloons, mirror, jogger, popMachine;
    public int tiklerCur, gasCur, baloonsCur, mirrorCur, joggerCur, popMachineCur;

    void Update()
    {
        if(buildings[0].activeSelf == true || buildings[1].activeSelf == true || buildings[2].activeSelf == true || buildings[3].activeSelf == true || buildings[4].activeSelf == true || buildings[5].activeSelf == true)
        {
            buildArea.SetActive(false);
            buildDeleater.SetActive(true);
        }
        else if(buildings[0].activeSelf == false && buildings[1].activeSelf == false && buildings[2].activeSelf == false && buildings[3].activeSelf == false && buildings[4].activeSelf == false && buildings[5].activeSelf == false)
        {
            buildArea.SetActive(true);
            buildDeleater.SetActive(false);
        }

        buildings[0].SetActive(popMachine);
        buildings[1].SetActive(baloons);
        buildings[2].SetActive(mirror);
        buildings[3].SetActive(jogger);
        buildings[4].SetActive(tikler);
        buildings[5].SetActive(gas);
    }

       public void TiklerBtn()
    {
        if(CurrencySliderController.instance.currencyValue >= tiklerCur && popMachine == false && gas == false && mirror == false && baloons == false && jogger == false)
        {
            tikler = true;
            CurrencySliderController.instance.currencyValue -= tiklerCur;
        }
    }

    public void PopMachineBtn()
    {
        if(CurrencySliderController.instance.currencyValue >= popMachineCur && tikler == false && gas == false && mirror == false && baloons == false && jogger == false)
        {
            popMachine = true;
            CurrencySliderController.instance.currencyValue -= popMachineCur;
        }
    }

    public void GasBtn()
    {
        if(CurrencySliderController.instance.currencyValue >= gasCur && popMachine == false && tikler == false && mirror == false && baloons == false && jogger == false)
        {
            gas = true;
            CurrencySliderController.instance.currencyValue -= gasCur;
        }
    }

    public void BaloonsBtn()
    {
        if(CurrencySliderController.instance.currencyValue >= baloonsCur && popMachine == false && gas == false && mirror == false && tikler == false && jogger == false)
        {
            baloons = true;
            CurrencySliderController.instance.currencyValue -= baloonsCur;
        }
    }

    public void MirrorBtn()
    {
        if(CurrencySliderController.instance.currencyValue >= mirrorCur && popMachine == false && gas == false && tikler == false && baloons == false && jogger == false)
        {
            mirror = true;
            CurrencySliderController.instance.currencyValue -= mirrorCur;
        }
    }
    public void JoggerBtn()
    {
        if(CurrencySliderController.instance.currencyValue >= joggerCur && popMachine == false && gas == false && mirror == false && baloons == false && tikler == false)
        {
            jogger = true;
            CurrencySliderController.instance.currencyValue -= joggerCur;
        }
    }
}
