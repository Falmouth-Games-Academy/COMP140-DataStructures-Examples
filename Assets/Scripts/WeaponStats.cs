using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public struct WeaponStats
{
    [SerializeField]
    public string name;

    [SerializeField]
    public float cost;

    [SerializeField]
    public float attack;

    [SerializeField]
    public int age;
}
