﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class OutOfControlCamera : MonoBehaviour
{
    public Camera OwnCamera;
    public Transform OwnTransform;
    public static OutOfControlCamera Current;

    private void Awake()
    {
        Current = this;
    }

    private void Start()
    {
        FadeIn();
    }

    public void FadeOut(System.Action fadeOut)
    {
        this.OwnCamera.FadeOut(1f, ()=>
        {
            this.gameObject.SetActive(false);
            fadeOut();
        });
    }
    
    public void SwitchOff()
    {
        this.gameObject.SetActive(false);
    }


    private void Update()
    {
    }

    public void FadeIn()
    {
        this.gameObject.SetActive(true);
        this.OwnCamera.FadeIn(1f);
    }
}