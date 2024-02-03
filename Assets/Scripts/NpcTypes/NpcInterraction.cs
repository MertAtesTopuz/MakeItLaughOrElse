using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcInterraction : MonoBehaviour
{
    public NpcChooser npc;

    public bool baloon, face, dark, magic, obje;

    public bool triggerControl;
    public bool interControl;

    public Sprite happyFeeling;
    public Sprite angryFeeling;
    public SpriteRenderer jokeSpi;

    void Start()
    {
        interControl = true;
    }

    void Update()
    {
        baloon = UIController.instance.buttonCheck[0];
        face = UIController.instance.buttonCheck[1];
        obje = UIController.instance.buttonCheck[2];
        magic = UIController.instance.buttonCheck[3];
        dark = UIController.instance.buttonCheck[4];

        NpcBehaviour();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            triggerControl = true;
        }
    }

   void OnTriggerExit2D(Collider2D other)
   {
    if (other.CompareTag("Player"))
        {
            triggerControl = false;
        }
   }

    private void NpcBehaviour()
    {
        if(triggerControl == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if(interControl == true)
                {
                    CurencyControl();
                    interControl = false;
                }
            }
        }
    }

    private void CurencyControl()
    {
        switch (npc.mainType.type)
        {
            case "Baloon Joke":
                if(baloon == true)
                {
                    CurrencySliderController.instance.currencyValue += 20 * SliderController.instance.sliderValue;
                    jokeSpi.sprite = happyFeeling;
                }
                else
                {
                    CurrencySliderController.instance.currencyValue -= 20;
                    jokeSpi.sprite = angryFeeling;
                }
                break;

            case "Magic Joke":
                if(magic == true)
                {
                    CurrencySliderController.instance.currencyValue += 20 * SliderController.instance.sliderValue;
                    jokeSpi.sprite = happyFeeling;
                }
                else
                {
                    CurrencySliderController.instance.currencyValue -= 20;
                    jokeSpi.sprite = angryFeeling;
                }
                break;

            case "Face Joke":
                if(face == true)
                {
                    CurrencySliderController.instance.currencyValue += 20 * SliderController.instance.sliderValue;
                    jokeSpi.sprite = happyFeeling;
                }
                else
                {
                    CurrencySliderController.instance.currencyValue -= 20;
                    jokeSpi.sprite = angryFeeling;
                }
                break;

            case "Dark Joke":
                if(dark == true)
                {
                    CurrencySliderController.instance.currencyValue += 20 * SliderController.instance.sliderValue;
                    jokeSpi.sprite = happyFeeling;
                }
                else
                {
                    CurrencySliderController.instance.currencyValue -= 20;
                    jokeSpi.sprite = angryFeeling;
                }
                break;

            case "Object Joke":
                if(obje == true)
                {
                    CurrencySliderController.instance.currencyValue += 20 * SliderController.instance.sliderValue;
                    jokeSpi.sprite = happyFeeling;
                }
                else
                {
                    CurrencySliderController.instance.currencyValue -= 20;
                    jokeSpi.sprite = angryFeeling;
                }
                break;
        } 
    }
}
