using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UIChange : MonoBehaviour
{
   
   public GameObject BuyArea;
   public GameObject BuyUi;
   public GameObject Build;
   public GameObject Build2;
   public GameObject Build3;
   public GameObject Build4;
   public GameObject Build5;
   public GameObject Build6;

   public GameObject AreaDemolisher;
    private CurrencySliderController currency;
    
    void Start()
    {
        currency = GetComponent<CurrencySliderController>();
    }
   
   public void Button1()
   {

     if(currency.currencyValue >= 200)
     {
        BuyUi.SetActive(false);
        BuyArea.SetActive(false);
        Build.SetActive(true);
        currency.currencyValue -= 200;
        AreaDemolisher.SetActive(true);
     }
   }
      public void Button2()
   {

     if(currency.currencyValue >= 200)
     {
        BuyUi.SetActive(false);
        BuyArea.SetActive(false);
        Build2.SetActive(true);
        currency.currencyValue -= 200;
        AreaDemolisher.SetActive(true);
     }
   }
      public void Button3()
   {

     if(currency.currencyValue >= 200)
     {
        BuyUi.SetActive(false);
        BuyArea.SetActive(false);
        Build3.SetActive(true);
        currency.currencyValue -= 200;
        AreaDemolisher.SetActive(true);
     }
   }
   public void Button4()
   {

     if(currency.currencyValue >= 200)
     {
        BuyUi.SetActive(false);
        BuyArea.SetActive(false);
        Build4.SetActive(true);
        currency.currencyValue -= 200;
        AreaDemolisher.SetActive(true);
     }
   }
      public void Button5()
   {

     if(currency.currencyValue >= 200)
     {
        BuyUi.SetActive(false);
        BuyArea.SetActive(false);
        Build5.SetActive(true);
        currency.currencyValue -= 200;
        AreaDemolisher.SetActive(true);
     }
   }
      public void Button6()
   {

     if(currency.currencyValue >= 200)
     {
        BuyUi.SetActive(false);
        BuyArea.SetActive(false);
        Build6.SetActive(true);
        currency.currencyValue -= 200;
        AreaDemolisher.SetActive(true);
     }
   }
}
