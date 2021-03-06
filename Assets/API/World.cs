﻿using System;
using System.Collections;
using System.Collections.Generic;
using API.InteractorScripts;
using UnityEngine;
using UnityEngine.SceneManagement;

public class World : MonoBehaviour
{
    public static World Current;
    public BuildingData BuildingEnterData;
    public Building PlayersHome;
    public Character Player;
    public AudioSource DoorOpen;
    public AudioSource DoorClose;
    public StoryInteractorScript WorldAnimator;
    public static bool ShowY;
    public static bool ShowPOutside;

    void Start()
    {
        Current = this;
        
        World.Current.OnBuildEnter(new BuildingData()
        {
            DoorPosition = PlayersHome.DoorExitSpawn.transform.position
        });
        
        OutOfControlCamera.Current.SwitchOff();
        SceneManager.LoadSceneAsync("PlayerHome", LoadSceneMode.Additive).completed += operation =>
        {
            GameRunTime.Current.Setup();
        };
    }
    
    public void OnBuildEnter( BuildingData data)
    {
        OutOfControlCamera.Current.OwnTransform.parent = null;
        BuildingEnterData = data;
        this.DoorOpen.Play();
    }

    public void OnBuildLeft()
    {
        this.DoorClose.Play();
        Character.Current.SetCharacterOn(this.BuildingEnterData.DoorPosition);
        Character.Current.SetCharacterLayer(LayerMask.NameToLayer("Player"));
        Character.Current.SetCameraOffset(OutOfControlCamera.Current.OwnTransform);
    }
}
