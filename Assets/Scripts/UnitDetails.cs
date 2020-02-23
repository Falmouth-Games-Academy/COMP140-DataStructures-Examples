using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This will allow us to make instances of the UnitDetails
//from the right click menu in project assets window
[CreateAssetMenu(fileName = "Unit",
    menuName = "ScriptableObjects/Create Unit Details", order = 1)]
public class UnitDetails : ScriptableObject
{
    //The name of the unit
    public string unitName;

    //The prefab of the unit
    public GameObject prefab;
}
