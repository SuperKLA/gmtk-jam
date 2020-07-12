﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var game = SceneManager.GetSceneByName("Game");
        var loaded = game.isLoaded;
        if (!loaded)
        {
            SceneManager.LoadSceneAsync("Game");
        }

        return;
    }    
}
