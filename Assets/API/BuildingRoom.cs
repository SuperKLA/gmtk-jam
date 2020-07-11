using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

[ExecuteAlways]
public class BuildingRoom : MonoBehaviour
{
    public Interactable ExitDoor;
    public GameObject SpawnPosition;
    
    private void Start()
    {
        ExitDoor.OnInteracting += DoorOnExit;
    }

    private void DoorOnExit()
    {
        SceneManager.UnloadSceneAsync("BuildingRoom").completed += operation =>
        {
            OutOfControlCamera.Current.FadeIn();
        };
    }

    private void Update()
    {
    }
}