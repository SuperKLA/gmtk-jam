using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

[ExecuteAlways]
public class BuildingRoomCamera : MonoBehaviour
{
    public Camera OwnCamera;
    
    private void Start()
    {
        this.OwnCamera.FadeIn(1f);
    }


    private void Update()
    {
    }
}