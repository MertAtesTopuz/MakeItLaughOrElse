using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class BuyAreaUi : MonoBehaviour
{

    public GameObject BuyUi;
    

    void OnTriggerEnter2D(Collider2D other)
    {
        if( other.CompareTag("Player"))
        {
            BuyUi.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if( other.CompareTag("Player"))
        {
            BuyUi.SetActive(false);
        }
    }
}
