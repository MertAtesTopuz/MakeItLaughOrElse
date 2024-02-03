using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballons3 : MonoBehaviour
{
    public GameObject BallonsB;
    void Start()
    {
        UIController.instance.maxCapasity += 5;
        
    }
}
