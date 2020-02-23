using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitManager : MonoBehaviour
{
    //Lits to hold all possible units
    [SerializeField]
    List<UnitDetails> avialableUnits = new List<UnitDetails>();

    //Dictionary of units that can be built
    Dictionary<string, UnitDetails> unitLookup = new Dictionary<string, UnitDetails>();

    //Spawn location
    [SerializeField]
    Transform spawnPoint;

    //The range to spawn units in
    [SerializeField]
    float spawnRange=2.0f;


    // Start is called before the first frame update
    void Start()
    {
        //Loop through all avialable units and add
        foreach(UnitDetails unit in avialableUnits)
        {
            Debug.Log("Added unit " + unit.unitName);
            unitLookup.Add(unit.unitName, unit);
        }
    }


    //Used to create units
    public void CreateUnit(string unitName)
    {
        //Check to see if we have a unit
        if (unitLookup.ContainsKey(unitName))
        {
            //Units to build
            UnitDetails unitToBuild = unitLookup[unitName];

            //Get a random spawn location in a circle
            Vector2 spawnLocationOffset = Random.insideUnitCircle * spawnRange;
            Vector3 spawnLocation = spawnPoint.transform.position;
            spawnLocation.x += spawnLocationOffset.x;
            spawnLocation.z += spawnLocationOffset.y;

            //Spawn
            Instantiate<GameObject>(unitToBuild.prefab, spawnLocation, Quaternion.identity);
        }
    }

    public List<UnitDetails> GetAvialableUnits()
    {
        return avialableUnits;
    }
}
