using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
public class BuyAreaUi2 : MonoBehaviour
{
    public GameObject BuyUiA;
    

    void OnTriggerEnter2D(Collider2D other)
    {
        if( other.CompareTag("Player"))
        {
            BuyUiA.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if( other.CompareTag("Player"))
        {
            BuyUiA.SetActive(false);
        }
    }
}
