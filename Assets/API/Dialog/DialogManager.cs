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
}
