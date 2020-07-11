using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

[ExecuteAlways]
public class OutOfControlCamera : MonoBehaviour
{
    public Camera OwnCamera;
    public static OutOfControlCamera Current;
    
    private void Start()
    {
        Current = this;
        FadeIn();
    }

    public void FadeOut(System.Action fadeOut)
    {
        this.OwnCamera.FadeOut(1f, fadeOut);
    }


    private void Update()
    {
    }

    public void FadeIn()
    {
        this.OwnCamera.FadeIn(1f);
    }
}