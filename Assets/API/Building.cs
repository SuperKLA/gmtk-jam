﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BuildingData
{
    public Vector3 DoorPosition { get; set; }
}

[ExecuteAlways]
public class Building : MonoBehaviour
{
    public SpriteRenderer Renderer;
    public SpriteMask MaskRenderer;
    
    public Transform MaskUp;
    public Transform MaskFront;
    public GameObject DoorExitSpawn;
    
    public Interactable Door;
    public string RoomName;

    void Start()
    {
        Door.OnInteracting += DoorOnInteracting;
    }

    private void Update()
    {
        var sortingFront = Mathf.RoundToInt(Renderer.transform.position.y * 100f) * -1;
        var sortingBack = Mathf.RoundToInt(MaskUp.position.y * 100f) * -1;
        var sortingFront2 = Mathf.RoundToInt(MaskFront.position.y * 100f) * -1;
        
        Renderer.sortingOrder = sortingFront;
        MaskRenderer.frontSortingOrder = sortingFront2;
        MaskRenderer.backSortingOrder = sortingBack;
    }

    private void OnValidate()
    {
        Renderer = this.GetComponentInChildren<SpriteRenderer>();
        MaskRenderer = this.GetComponentInChildren<SpriteMask>();
        
        Door.gameObject.SetActive(!string.IsNullOrEmpty(this.RoomName));
    }
    
    private void DoorOnInteracting()
    {
        if (string.IsNullOrEmpty(this.RoomName)) return;

        Door.CanInteract = false;
        World.Current.OnBuildEnter(new BuildingData()
        {
            DoorPosition = this.DoorExitSpawn.transform.position
        });
        
        OutOfControlCamera.Current.FadeOut(() =>
        {
            SceneManager.LoadSceneAsync(this.RoomName, LoadSceneMode.Additive).completed += operation =>
            {

            };
        });
    }
}
