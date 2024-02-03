using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demolisher2 : MonoBehaviour
{
public GameObject BuildA;

   public GameObject BuyAreaA;
  public GameObject Build2A;
  public GameObject Build3A;
  public GameObject Build4A;
  public GameObject Build5A;
  public GameObject Build6A;
  public GameObject BuildDeleterCodeBoxA;
   void OnTriggerEnter2D(Collider2D other)
    {
        if( other.CompareTag("Player"))
        {
            BuildA.SetActive(false);
            Build2A.SetActive(false);
            Build3A.SetActive(false);
            Build4A.SetActive(false);
            Build5A.SetActive(false);
            Build6A.SetActive(false);
            BuildDeleterCodeBoxA.SetActive(false);
            BuyAreaA.SetActive(true);
        }
    }
}
