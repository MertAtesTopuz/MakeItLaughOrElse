using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : MonoBehaviour
{


    public GameObject MirrorObj;
    void Start()
    {
        SliderController.instance.sliderValue +=1;
    }
}
