using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tickler2 : MonoBehaviour
{
   public GameObject ticklerObjA;
    // Start is called before the first frame update
    void Start()
    {
          UIController.instance.maxCapasity += 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
