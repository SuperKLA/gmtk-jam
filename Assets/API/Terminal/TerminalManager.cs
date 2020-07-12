using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerminalManager : MonoBehaviour
{
    public static TerminalManager Current;
    public GameObject Terminal;

    private void Awake()
    {
        Current = this;
    }

    public void ShowOrCloseTerminal(bool value)
    {
        GameRunTime.TerminalOpen = value;
        Terminal.SetActive(value);
    }


}
