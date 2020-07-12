using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRunTime : MonoBehaviour
{
    DialogManager DM { get { return DialogManager.Current; } }
    public static GameRunTime Current;
    public static bool SpaceUPCanFire = false;
    public static bool ConsoleOpen = false;
    
    private void Awake()
    {
        Current = this;
    }
    
    public void Setup()
    {
        EventTriggert(Interactive.Start);
    }

    public void EventTriggert(Interactive iteracted)
    {
        switch (iteracted)
        {
            case Interactive.Start:
                if (Dialogs.nextInteractor == StoryInteractor.GAME_START)
                    TriggerDialog(Dialogs.Dialog11);
                else
                    TriggerDialog(null);
                break;
            case Interactive.EnterCTRL:
                if (Dialogs.nextInteractor == StoryInteractor.CTRL_TOWER_SHIFT)
                    TriggerDialog(Dialogs.Dialog12);
                else
                    TriggerDialog(null);
                break;
            case Interactive.StartTerminal:
                if (Dialogs.nextInteractor == StoryInteractor.TERMINAL_START)
                    TriggerDialog(Dialogs.Dialog13);
                else
                    TriggerDialog(null);
                break;
            case Interactive.N:
                if (Dialogs.nextInteractor == StoryInteractor.N_IFR_POWER_PLANT_FIRST_TIME)
                    TriggerDialog(Dialogs.Dialog14);
                else if (Dialogs.nextInteractor == StoryInteractor.N_IFR_POWER_PLANT_SECOND_TIME)
                    TriggerDialog(Dialogs.Dialog16);
                else
                    TriggerDialog(Dialogs.Idle_N);
                break;
            case Interactive.S:
                if (Dialogs.nextInteractor == StoryInteractor.S_IN_SHOP_TALKT_TO)
                    TriggerDialog(Dialogs.Dialog15);
                else
                    TriggerDialog(Dialogs.Idle_S);
                break;
            case Interactive.T:
                if (Dialogs.nextInteractor == StoryInteractor.T_IFR_WITH_Y)
                    TriggerDialog(Dialogs.Dialog21);
                else
                    TriggerDialog(Dialogs.Idle_T);
                break;
            case Interactive.CalenderInteract:
                if (Dialogs.nextInteractor == StoryInteractor.CALENDAR_AT_Y)
                    TriggerDialog(Dialogs.Dialog22);
                else
                    TriggerDialog(Dialogs.Idle_Calendar);
                break;
            case Interactive.Y:
                if (Dialogs.nextInteractor == StoryInteractor.Y_IFR_TEAHOUSE)
                    TriggerDialog(Dialogs.Dialog23);
                else
                    TriggerDialog(Dialogs.Idle_Y);
                break;
            case Interactive.K:
                if (Dialogs.nextInteractor == StoryInteractor.K_IFR_P)
                    TriggerDialog(Dialogs.Dialog31);
                else if (Dialogs.nextInteractor == StoryInteractor.K_IFR_K_SHOP)
                    TriggerDialog(Dialogs.Dialog32);
                else if (Dialogs.nextInteractor == StoryInteractor.K_TALK_TO_K_D_J_L)
                    TriggerDialog(Dialogs.Dialog36);
                else
                    TriggerDialog(Dialogs.Idle_K);
                break;
            case Interactive.R:
                if (Dialogs.nextInteractor == StoryInteractor.R_TALK_TO_R_OR_P)
                    TriggerDialog(Dialogs.Dialog33);
                else
                    TriggerDialog(Dialogs.Idle_R);
                break;
            case Interactive.P:
                if (Dialogs.nextInteractor == StoryInteractor.R_TALK_TO_R_OR_P)
                    TriggerDialog(Dialogs.Dialog33);
                else if (Dialogs.nextInteractor == StoryInteractor.P_IFR_BAR)
                    TriggerDialog(Dialogs.Dialog35);
                else
                    TriggerDialog(Dialogs.Idle_P);
                break;
            case Interactive.D:
                if (Dialogs.nextInteractor == StoryInteractor.D_IFR_VET)
                    TriggerDialog(Dialogs.Dialog34);
                else if (Dialogs.nextInteractor == StoryInteractor.K_TALK_TO_K_D_J_L)
                    TriggerDialog(Dialogs.Dialog36);
                else
                    TriggerDialog(Dialogs.Idle_D);
                break;
            case Interactive.J:
                if (Dialogs.nextInteractor == StoryInteractor.K_TALK_TO_K_D_J_L)
                    TriggerDialog(Dialogs.Dialog36);
                else
                    TriggerDialog(Dialogs.Idle_J);
                break;
            case Interactive.L:
                if (Dialogs.nextInteractor == StoryInteractor.K_TALK_TO_K_D_J_L)
                    TriggerDialog(Dialogs.Dialog36);
                else
                    TriggerDialog(Dialogs.Idle_L);
                break;
            case Interactive.EnterEnter:
                break;
            default:
                break;
        }

    }

    private void TriggerDialog(Queue<DialogText> dialog)
    {
        if (!DM.IsDialogActive)
            DM.StartDialog(dialog);
        else
            DM.NextTextInDialog();
    }

}

