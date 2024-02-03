using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
public class BuyUiChanger3 : MonoBehaviour
{
  public GameObject BuyAreaB;
   public GameObject BuyUiB;
   public GameObject BuildB;
   public GameObject Build2B;
   public GameObject Build3B;
   public GameObject Build4B;
   public GameObject Build5B;
   public GameObject Build6B;

   public GameObject AreaDemolisherB;
    private CurrencySliderController currency;
    
    void Start()
    {
        currency = GetComponent<CurrencySliderController>();
    }
   
   public void Button1B()
   {

     if(currency.currencyValue >= 200)
     {
        BuyUiB.SetActive(false);
        BuyAreaB.SetActive(false);
        BuildB.SetActive(true);
        currency.currencyValue -= 200;
        AreaDemolisherB.SetActive(true);
     }
   }
      public void Button2B()
   {

     if(currency.currencyValue >= 200)
     {
        BuyUiB.SetActive(false);
        BuyAreaB.SetActive(false);
        Build2B.SetActive(true);
        currency.currencyValue -= 200;
        AreaDemolisherB.SetActive(true);
     }
   }
      public void Button3B()
   {

     if(currency.currencyValue >= 200)
     {
        BuyUiB.SetActive(false);
        BuyAreaB.SetActive(false);
        Build3B.SetActive(true);
        currency.currencyValue -= 200;
        AreaDemolisherB.SetActive(true);
     }
   }
   public void Button4B()
   {

     if(currency.currencyValue >= 200)
     {
        BuyUiB.SetActive(false);
        BuyAreaB.SetActive(false);
        Build4B.SetActive(true);
        currency.currencyValue -= 200;
        AreaDemolisherB.SetActive(true);
     }
   }
      public void Button5B()
   {

     if(currency.currencyValue >= 200)
     {
        BuyUiB.SetActive(false);
        BuyAreaB.SetActive(false);
        Build5B.SetActive(true);
        currency.currencyValue -= 200;
        AreaDemolisherB.SetActive(true);
     }
   }
      public void Button6B()
   {

     if(currency.currencyValue >= 200)
     {
        BuyUiB.SetActive(false);
        BuyAreaB.SetActive(false);
        Build6B.SetActive(true);
        currency.currencyValue -= 200;
        AreaDemolisherB.SetActive(true);
     }
   }
}
