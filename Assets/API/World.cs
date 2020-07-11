using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class World : MonoBehaviour
{
    public static World Current;
    public BuildingData BuildingEnterData;

    void Start()
    {
        Current = this;
    }
    
    public void OnBuildEnter( BuildingData data)
    {
        BuildingEnterData = data;
    }

    public void OnBuildLeft()
    {
        Character.Current.SetCharacterOn(this.BuildingEnterData.DoorPosition);
        Character.Current.SetCharacterLayer(LayerMask.NameToLayer("Player"));
    }
}
