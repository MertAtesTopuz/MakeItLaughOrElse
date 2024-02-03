using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogger2 : MonoBehaviour
{
    public GameObject JoggerObjA;
    // Start is called before the first frame update
    void Start()
    {
        SliderController.instance.sliderValue +=2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
