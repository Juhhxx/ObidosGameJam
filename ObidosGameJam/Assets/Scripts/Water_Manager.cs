using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Water_Manager : MonoBehaviour
{
    [SerializeField] private Image waterBar;
    [SerializeField] public float waterAmount = 100f;
    [SerializeField] private float usage;
    [SerializeField] private float refillAmount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UsingWater() {
        waterAmount -= usage;
        waterBar.fillAmount = waterAmount / 100f;
    }
    public void WaterRefill() {
        waterAmount += refillAmount;
        waterAmount = Math.Clamp(waterAmount,0,100);

        waterBar.fillAmount = waterAmount / 100f;
    }
}
