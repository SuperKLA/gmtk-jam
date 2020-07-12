﻿using System;
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
    }

    public void Show()
    {
        this.Container.SetActive(true);
    }
}
