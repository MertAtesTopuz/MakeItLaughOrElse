using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
public class BuyAreaUiController2 : MonoBehaviour
{
public GameObject BuyAreaA;
   public GameObject BuyUiA;
   public GameObject BuildA;
   public GameObject Build2A;
   public GameObject Build3A;
   public GameObject Build4A;
   public GameObject Build5A;
   public GameObject Build6A;

   public GameObject AreaDemolisher;
    private CurrencySliderController currency;
    
    void Start()
    {
        currency = GetComponent<CurrencySliderController>();
    }
   
   public void Button1A()
   {

     if(currency.currencyValue >= 200)
     {
        BuyUiA.SetActive(false);
        BuyAreaA.SetActive(false);
        BuildA.SetActive(true);
        currency.currencyValue -= 200;
        AreaDemolisher.SetActive(true);
     }
   }
      public void Button2A()
   {

     if(currency.currencyValue >= 200)
     {
        BuyUiA.SetActive(false);
        BuyAreaA.SetActive(false);
        Build2A.SetActive(true);
        currency.currencyValue -= 200;
        AreaDemolisher.SetActive(true);
     }
   }
      public void Button3A()
   {

     if(currency.currencyValue >= 200)
     {
        BuyUiA.SetActive(false);
        BuyAreaA.SetActive(false);
        Build3A.SetActive(true);
        currency.currencyValue -= 200;
        AreaDemolisher.SetActive(true);
     }
   }
   public void Button4A()
   {

     if(currency.currencyValue >= 200)
     {
        BuyUiA.SetActive(false);
        BuyAreaA.SetActive(false);
        Build4A.SetActive(true);
        currency.currencyValue -= 200;
        AreaDemolisher.SetActive(true);
     }
   }
      public void Button5A()
   {

     if(currency.currencyValue >= 200)
     {
        BuyUiA.SetActive(false);
        BuyAreaA.SetActive(false);
        Build5A.SetActive(true);
        currency.currencyValue -= 200;
        AreaDemolisher.SetActive(true);
     }
   }
      public void Button6A()
   {

     if(currency.currencyValue >= 200)
     {
        BuyUiA.SetActive(false);
        BuyAreaA.SetActive(false);
        Build6A.SetActive(true);
        currency.currencyValue -= 200;
        AreaDemolisher.SetActive(true);
     }
   }
}
