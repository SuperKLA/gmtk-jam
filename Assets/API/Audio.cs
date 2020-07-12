using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Audio : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider slider;

    public AudioSource audiosourceAkt1;
    public AudioSource audiosourceAkt2;
    public AudioSource audiosourceAkt3;

    public static Audio current;

    private void Awake()
    {
        current = this;
    }

    private void Start()
    {
        StartAct1();
    }

    public void ChangeVolume(float value)
    {
        audioMixer.SetFloat("MasterVolume", Mathf.Log10(value) * 20);
    }
    
    public void ChangeSFXVolume(float value)
    {
        audioMixer.SetFloat("SFX", Mathf.Log10(value) * 20);
    }
    
    public void ChangeMusicVolume(float value)
    {
        audioMixer.SetFloat("Music", Mathf.Log10(value) * 20);
    }

    public void StartSound(Akt akt)
    {
        switch (akt)
        {
            case Akt.Akt1:
                StartAct1();
                break;
            case Akt.Akt2:
                StartAct2();
                break;
            case Akt.Akt3:
                StartAct3();
                break;
            default:
                break;
        }
    }


    private void StartAct1()
    {
        audiosourceAkt3.Stop();
        audiosourceAkt2.Stop();
        audiosourceAkt1.Play();
    }

    private void StartAct2()
    {
        audiosourceAkt3.Stop();
        audiosourceAkt1.Stop();
        audiosourceAkt2.Play();
    }

    private void StartAct3()
    {
        audiosourceAkt2.Stop();
        audiosourceAkt1.Stop();
        audiosourceAkt3.Play();
    }
}
