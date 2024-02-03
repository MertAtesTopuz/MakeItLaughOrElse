using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
public class Demolisher3 : MonoBehaviour
{
public GameObject BuildB;

   public GameObject BuyAreaB;
  public GameObject Build2B;
  public GameObject Build3B;
  public GameObject Build4B;
  public GameObject Build5B;
  public GameObject Build6B;
  public GameObject BuildDeleterCodeBoxB;
   void OnTriggerEnter2D(Collider2D other)
    {
        if( other.CompareTag("Player"))
        {
            BuildB.SetActive(false);
            Build2B.SetActive(false);
            Build3B.SetActive(false);
            Build4B.SetActive(false);
            Build5B.SetActive(false);
            Build6B.SetActive(false);
            BuildDeleterCodeBoxB.SetActive(false);
            BuyAreaB.SetActive(true);
        }
    }
}
