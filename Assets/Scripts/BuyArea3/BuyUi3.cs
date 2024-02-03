using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
public class BuyUi3 : MonoBehaviour
{
public GameObject BuyUiB;
    

    void OnTriggerEnter2D(Collider2D other)
    {
        if( other.CompareTag("Player"))
        {
            BuyUiB.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if( other.CompareTag("Player"))
        {
            BuyUiB.SetActive(false);
        }
    }
}
