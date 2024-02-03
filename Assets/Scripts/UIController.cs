using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public static UIController instance;

    [Header("Button Variables")]
    public int buttonValue;
    public bool[] buttonCheck;

    [Header("Pnl")]
    public GameObject goodPnl;
    public GameObject badPnl;


    [Header("Capacity Variables")]
    public TextMeshProUGUI capasityText;
    public int maxCapasity;
    public int currentCapacity;

    [Header("Select")]
    public GameObject selectObj1;
    public GameObject selectObj2;
    public GameObject selectObj3;
    public GameObject selectObj4;
    public GameObject selectObj5;




    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        ButtonOpen();
        CapacityUpdater();

        if(TimeManager.instance.isNight == true)
        {
            if(CurrencySliderController.instance.currencyValue <= 8000)
            {
                
                badPnl.SetActive(true);
               
            }
            else if(CurrencySliderController.instance.currencyValue > 8000)
            {
                
                goodPnl.SetActive(true);
              
            }
        }
    }

    #region Capacity Methods

    private void CapacityUpdater()
    {
        capasityText.text = maxCapasity + "/" + currentCapacity;
    }

    #endregion


    #region Button Methods
    private void ButtonOpen()
    {

        for (int i = 0; i < buttonCheck.Length; i++)
        {
            if (i != buttonValue)
            {
                buttonCheck[i] = false;
            }
            else if (i == buttonValue)
            {
                buttonCheck[i] = true;
            }
        }
        
    }

    public void ButtonZero()
    {
        buttonValue = 0;
        selectObj1.SetActive(true);
        selectObj2.SetActive(false);
        selectObj3.SetActive(false);
        selectObj4.SetActive(false);
        selectObj5.SetActive(false);
    }

    public void ButtonOne()
    {
        buttonValue = 1;
        selectObj1.SetActive(false);
        selectObj2.SetActive(true);
        selectObj3.SetActive(false);
        selectObj4.SetActive(false);
        selectObj5.SetActive(false);
    }

    public void ButtonTwo()
    {
        buttonValue = 2;
        selectObj1.SetActive(false);
        selectObj2.SetActive(false);
        selectObj3.SetActive(true);
        selectObj4.SetActive(false);
        selectObj5.SetActive(false);
    }

    public void ButtonThree()
    {
        buttonValue = 3;
        selectObj1.SetActive(false);
        selectObj2.SetActive(false);
        selectObj3.SetActive(false);
        selectObj4.SetActive(true);
        selectObj5.SetActive(false);
    }

    public void ButtonFour()
    {
        buttonValue = 4;
        selectObj1.SetActive(false);
        selectObj2.SetActive(false);
        selectObj3.SetActive(false);
        selectObj4.SetActive(false);
        selectObj5.SetActive(true);
    }
    #endregion

    public void RestartBtn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MenuBtn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
    }
}
