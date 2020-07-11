using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class BuildingRoomCamera : MonoBehaviour
{
    public Camera OwnCamera;
    
    private void Start()
    {
        this.OwnCamera.FadeIn(1f);
    }


    public void FadeOut(System.Action fadeOut)
    {
        this.OwnCamera.FadeOut(1f, ()=>
        {
            this.gameObject.SetActive(false);
            fadeOut();
        });
    }
}