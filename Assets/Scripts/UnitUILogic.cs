using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitUILogic : MonoBehaviour
{
    [SerializeField]
    UnitManager unitManager;

    //Button Handlers for red, blue, white and green
    public void CreateRedPressed()
    {

        unitManager.CreateUnit("Red");
    }

    public void CreateBluePressed()
    {
        unitManager.CreateUnit("Blue");
    }

    public void CreateWhitePressed()
    {
        unitManager.CreateUnit("White");
    }

    public void CreateGreenPressed()
    {
        unitManager.CreateUnit("Green");
    }
}
