using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildMakingArea : MonoBehaviour
{
    public GameObject buildUI;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            buildUI.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            buildUI.SetActive(false);
        }
    }
}
