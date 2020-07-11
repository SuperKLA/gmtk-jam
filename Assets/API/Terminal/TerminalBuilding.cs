using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Terminal Building", menuName ="Terminal_Building")]
public class TerminalBuilding : ScriptableObject
{
    public new string name;
    public Sprite image;
    public BuildingState state;
}
