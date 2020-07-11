using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerminalControl : MonoBehaviour
{

    public TerminalBuildingDisplay tbp;

    public TerminalBuilding Hospital;
    public TerminalBuilding Police;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            tbp.SetNewTerminalBuilding(Hospital);
        }


        if (Input.GetKeyDown(KeyCode.P))
        {
            tbp.SetNewTerminalBuilding(Police);
        }
    }

}
