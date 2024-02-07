using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Cleaning : MonoBehaviour
{
    private Animator mAnimator;
    public int cleaned = 0;
    // Start is called before the first frame update
    void Start()
    {
        mAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startClean()
    {
        mAnimator.Play("cleaning_setup");
        Debug.Log("Clean");
    }

    public void isClean()
    {
        cleaned += 1;
        Debug.Log("Cleaning " + cleaned);
    }
}
