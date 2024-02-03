using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baloons : MonoBehaviour
{

    public GameObject Ballons;
    void Start()
    {
        UIController.instance.maxCapasity += 5;
        
    }
}
