using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;
using UnityEngine.Rendering.Universal;


public class TimeManager : MonoBehaviour
{
    public static TimeManager instance;
    public static int Minute { get; private set; }
    public static int Hour { get; private set; }
    public static int LightI { get; private set; }

    private float minuteToRealTime = 1f;
    private float timer;

    public int startHour;
    public int startMinute;
    public int nightHour;
    public int nightMinute;

    public Sprite day;
    public Sprite night;

    public Light2D mainLight;
    private bool lightTimer;
    public bool isNightS;
    public bool isNight;

    public GameObject barbarosImg;

    [Header("UI")]
    public Image img;
    public TextMeshProUGUI txtPro;

    [Header("UIType")]
    public Color dayColor;
    public Color nightColor;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        img.sprite = day;
        Minute = startMinute;
        Hour = startHour;
        timer = minuteToRealTime;
    }

    void Update()
    {
        MainTimer();
        txtPro.text = Hour.ToString()+ ":" + Minute.ToString("00");
        
        ChangeSprite();
    }

    private void MainTimer()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Minute++;
            if (lightTimer == true)
            {
                LightUpdater();
            }
            
            if (Minute > 60)
            {
                Hour++;
                Minute = 0;
            }
            timer = minuteToRealTime;
        }
    }

   private void ChangeSprite()
    {
        if (Hour == nightHour && Minute == nightMinute)
        {
            img.sprite = night;
            lightTimer = true;
            
        }
    }
    private void LightUpdater()
    {
            mainLight.intensity -= 0.1f;
            isNightS = true;

            if (mainLight.intensity <= 0.05f)
            {
                mainLight.intensity = 0.05f;
                //barbarosImg.SetActive(true);
                isNight = true;
            }
    }
}
