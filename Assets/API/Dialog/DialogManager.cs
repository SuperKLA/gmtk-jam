using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    private bool dialogActive = false;
    private Queue<DialogText> currentDialog;

    public GameObject dialogImage;
    public TMP_Text speakerText;
    public TMP_Text dialogText;

    #region AudioVoice
    public AudioSource audioSource;
    public AudioClip voice_D;
    public AudioClip voice_GG;
    public AudioClip voice_J;
    public AudioClip voice_K;
    public AudioClip voice_L;
    public AudioClip voice_N;
    public AudioClip voice_P;
    public AudioClip voice_R;
    public AudioClip voice_S;
    public AudioClip voice_SHIFT;
    public AudioClip voice_SPACE;
    public AudioClip voice_T;
    public AudioClip voice_Y;
    #endregion AudioVoice



    public bool IsDialogActive { get { return dialogActive; } }
    public bool openTerminalAfterDialog = false;

    public static DialogManager Current;

    private void Awake()
    {
        Current = this;
    }



    public void StartDialog(Queue<DialogText> dialog)
    {
        if (!dialogActive)
        {
            dialogActive = true;
            currentDialog = dialog;
            ShowDialog();
        }
    }

    public void NextTextInDialog()
    {
        ShowDialog();
    }


    public void StopDialog()
    {
        audioSource.Stop();
        dialogActive = false;
        HideDialog();

        if (openTerminalAfterDialog)
        {
            openTerminalAfterDialog = false;
            GameRunTime.Current.OpenOrCloseTerminal(true);
        }

        SpecialEventHandling();
    }

    private void SpecialEventHandling()
    {
        switch (Dialogs.nextInteractor)
        {
            case StoryInteractor.TERMINAL_START:
                if (BuildingRoom.Current == null || BuildingRoom.Current.StoryInteractorScript == null) return;
                BuildingRoom.Current.StoryInteractorScript.Play();
                break;
            case StoryInteractor.K_IFR_P:
                World.Current.WorldAnimator.Play("Y_IFR_TEAHOUSE");
                World.ShowY = true;
                break;
            case StoryInteractor.K_IFR_K_SHOP:
                World.Current.WorldAnimator.Play("K_IFR_K_SHOP");
                break;
            case StoryInteractor.P_IFR_BAR:
                World.Current.WorldAnimator.Play("D_IFR_VET");
                break;
            case StoryInteractor.K_TALK_TO_K_D_J_L:
                World.Current.WorldAnimator.Play("K_TALK_TO_K_D_J_L 2");
                break;
        }
    }

    private void ShowDialog()
    {
        if (currentDialog != null && currentDialog.Count > 0)
        {
            DialogText nextDialog = currentDialog.Dequeue();
            speakerText.text = nextDialog.Speaker;
            dialogText.text = nextDialog.Text;
            dialogImage.SetActive(true);
            PlayVoice(nextDialog.Speaker);
        }
        else
        {
            StopDialog();
        }
    }

    private void HideDialog()
    {
        dialogImage.gameObject.SetActive(false);
        currentDialog = null;
        speakerText.text = "";
        dialogText.text = "";
    }

    private void PlayVoice(string Speaker)
    {
        AudioClip clipToPlay = null;
        switch (Speaker)
        {
            case "SPACE:":
                clipToPlay = voice_SPACE;
                break;
            case "SHIFT:":
                clipToPlay = voice_SHIFT;
                break;
            case "D:":
                clipToPlay = voice_D;
                break;
            case "GG:":
                clipToPlay = voice_GG;
                break;
            case "J:":
                clipToPlay = voice_J;
                break;
            case "K:":
                clipToPlay = voice_K;
                break;
            case "L:":
                clipToPlay = voice_L;
                break;
            case "N:":
                clipToPlay = voice_N;
                break;
            case "P:":
                clipToPlay = voice_P;
                break;
            case "R:":
                clipToPlay = voice_R;
                break;
            case "S:":
                clipToPlay = voice_S;
                break;
            case "T:":
                clipToPlay = voice_T;
                break;
            case "Y:":
                clipToPlay = voice_Y;
                break;
            default:
                break;
        }

        if (clipToPlay != null)
            audioSource.PlayOneShot(clipToPlay);
    }

}
