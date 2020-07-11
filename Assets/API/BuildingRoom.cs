using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class BuildingRoom : MonoBehaviour
{
    public Interactable ExitDoor;
    public GameObject SpawnPosition;
    public BuildingRoomCamera BuildingRoomCamera;
    public bool CanExitRoom = false;
    
    private void Start()
    {
        ExitDoor.OnInteracting += DoorOnExit;
        this.CanExitRoom = !this.ExitDoor.IsInBounds(Character.Current.OwnCollider.bounds);
        
        Character.Current.SetCharacterOn(this.SpawnPosition.transform.position);
        Character.Current.SetCharacterLayer(LayerMask.NameToLayer("BuildingRoom"));
        
        Character.Current.CharacterInput.OnMove += CharacterInputOnOnMove;
    }

    private void CharacterInputOnOnMove()
    {
        if (this.CanExitRoom) return;
        
        this.CanExitRoom = !this.ExitDoor.IsInBounds(Character.Current.OwnCollider.bounds);
    }

    private void DoorOnExit()
    {
        Character.Current.CharacterInput.OnMove -= CharacterInputOnOnMove;
        
        BuildingRoomCamera.FadeOut(() =>
        {
            SceneManager.UnloadSceneAsync("BuildingRoom").completed += operation =>
            {
                OutOfControlCamera.Current.FadeIn();
                World.Current.OnBuildLeft();
            };
        });
    }
}