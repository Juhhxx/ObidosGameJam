using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stamina_Manager : MonoBehaviour
{
    [SerializeField] private Image staminaBar;
    [SerializeField] public float staminaAmount = 100f;
    [SerializeField] private float usage;
    [SerializeField] private float refillAmount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        staminaAmount -= 0.005f;
        staminaBar.fillAmount = staminaAmount / 100f;

    }

    public void DoingStuff() {
        staminaAmount -= usage;
        staminaBar.fillAmount = staminaAmount / 100f;
    }
    public void Ginginha() {
        staminaAmount += refillAmount;
        staminaAmount = Math.Clamp(staminaAmount,0,100);

        staminaBar.fillAmount = staminaAmount / 100f;
    }
}
