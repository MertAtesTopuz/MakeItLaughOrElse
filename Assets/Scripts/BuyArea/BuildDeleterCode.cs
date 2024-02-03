using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;


public class BuildDeleterCode : MonoBehaviour
{
  public GameObject Build;

   public GameObject BuyArea;
  public GameObject Build2;
  public GameObject Build3;
  public GameObject Build4;
  public GameObject Build5;
  public GameObject Build6;
  public GameObject BuildDeleterCodeBox;
   void OnTriggerEnter2D(Collider2D other)
    {
        if( other.CompareTag("Player"))
        {
            Build.SetActive(false);
            Build2.SetActive(false);
            Build3.SetActive(false);
            Build4.SetActive(false);
            Build5.SetActive(false);
            Build6.SetActive(false);
            BuildDeleterCodeBox.SetActive(false);
            BuyArea.SetActive(true);
        }
    }
}
