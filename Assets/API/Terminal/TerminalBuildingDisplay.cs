using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TerminalBuildingDisplay : MonoBehaviour
{
    public TerminalBuilding terminalBuilding;

    public Image buildingImage;
    public TMP_Text buildingName;
    public TMP_Text buildingState;

    private void Start()
    {
        SetValues();
    }

    public void SetNewTerminalBuilding(TerminalBuilding newBuilding)
    {
        terminalBuilding = newBuilding;
        SetValues();
    }

    private void SetValues()
    {
        buildingImage.sprite = terminalBuilding.image;
        buildingName.text = terminalBuilding.name;
        buildingState.faceColor = new Color32(255, 255, 255, 255);
        if (terminalBuilding.state == BuildingState.ALERT)
        {
            StopAllCoroutines();
            StartCoroutine(ERRORText());
        }
        else
        {
            StopAllCoroutines();
            StartCoroutine(OKText());
        }
    }

    public IEnumerator OKText()
    {
        //set the Text's text to blank
        buildingState.text = ".";
        yield return new WaitForSeconds(.5f);
        buildingState.text = "..";
        yield return new WaitForSeconds(.5f);
        buildingState.faceColor = new Color32(0, 255, 0, 255);
        buildingState.text = "OK";
        yield return new WaitForSeconds(.5f);

    }


    public IEnumerator ERRORText()
    {
        buildingState.text = ".";
        yield return new WaitForSeconds(.5f);
        buildingState.text = "..";
        yield return new WaitForSeconds(.5f);
        buildingState.text = "";
        buildingState.faceColor = new Color32(255, 0, 0, 255);
        while (true)
        {
            buildingState.text = "";
            yield return new WaitForSeconds(.5f);
            buildingState.text = "ALERT";
            yield return new WaitForSeconds(.5f);
        }
    }
}
