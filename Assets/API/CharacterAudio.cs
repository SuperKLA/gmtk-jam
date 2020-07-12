using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CharacterAudio : MonoBehaviour
{
    public List<AudioSource> FootSteps;

    private void OnValidate()
    {
        FootSteps = FootSteps ?? new List<AudioSource>();
        FootSteps.Clear();
        
        FootSteps.AddRange(this.GetComponentsInChildren<AudioSource>(true));
    }

    public void PlayFootStep()
    {
        var i = Random.Range(0, this.FootSteps.Count);
        this.FootSteps[i].Play();
    }
}