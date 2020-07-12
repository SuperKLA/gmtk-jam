using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalScreen : MonoBehaviour
{
    public static FinalScreen Current;
    public GameObject Container;
    
    public void Awake()
    {
        Current = this;
        this.Container.SetActive(false);
    }

    [ContextMenu("Show")]
    public void Show()
    {
        Audio.current.ChangeVolume(0);
        Audio.current.ChangeSFXVolume(0);
        Audio.current.ChangeMusicVolume(0);
        
        this.Container.SetActive(true);
    }
}
