using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballons2 : MonoBehaviour
{
   public GameObject BallonsA;
    void Start()
    {
        UIController.instance.maxCapasity += 5;
        
    }
}
