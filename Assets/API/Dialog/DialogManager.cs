using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{

    private bool dialogActive = false;
    private Queue<DialogText> currentDialog;

    public Image dialogImage;
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
        if(openTerminalAfterDialog)
        {
            openTerminalAfterDialog = false;
            GameRunTime.Current.OpenOrCloseTerminal(true);
        }
    }


    private void ShowDialog()
    {
        if (currentDialog != null && currentDialog.Count > 0)
        {
            DialogText nextDialog = currentDialog.Dequeue();
            speakerText.text = nextDialog.Speaker;
            dialogText.text = nextDialog.Text;
            dialogImage.gameObject.SetActive(true);
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
