using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildDeleater : MonoBehaviour
{   
    public BuildControl control;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            control.baloons = false;
            control.gas = false;
            control.mirror = false;
            control.jogger = false;
            control.tikler = false;
            control.popMachine = false;
        }
    }
}
