using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEditor;
using UnityEngine;

public class Cleaning : MonoBehaviour
{
    private Animator mAnimator;
    private Animator grafAnimator;
    [SerializeField] Water_Manager waterBar;
    [SerializeField] Stamina_Manager staminaBar;
    private GameObject toClean;
    [SerializeField] GameObject cleaningThis;

    // Start is called before the first frame update
    void Start()
    {
        mAnimator = GetComponent<Animator>();
        waterBar = GetComponent<Water_Manager>();
        staminaBar = GetComponent<Stamina_Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startClean()
    {
        if (waterBar.waterAmount > 0f && staminaBar.staminaAmount > 0f) {
            mAnimator.Play("cleaning_setup");
            Debug.Log("Clean");
        }
        else {
            Debug.Log("No Water");
        }

    }

    public void isClean()
    {
        
        toClean = GameObject.Find(cleaningThis.name + "(Clone)");
        // cleaned += 1;
        // Debug.Log("Cleaning " + cleaned);
        
        if (toClean == null) {
            mAnimator.Play("cleaning_back");
        }
        else {
            grafAnimator = toClean.GetComponent<Animator>();
            // grafAnimator.Play("cleaned");
            Destroy(toClean);
            
        }
        
    }

    public void refillWater()
    {
        if (staminaBar.staminaAmount > 0f) {
            mAnimator.Play("water_refill");
        }
    }
}
