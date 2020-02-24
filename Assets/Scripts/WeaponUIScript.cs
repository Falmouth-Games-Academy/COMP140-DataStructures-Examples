using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponUIScript : MonoBehaviour
{

    [SerializeField]
    Text nameTextBox;

    [SerializeField]
    Text priceTextBox;

    [SerializeField]
    Text damageTextBox;

    [SerializeField]
    Text ageTextBox;

    WeaponStats weapon;


    public void SetWeapon(WeaponStats currentWeapon)
    {
        nameTextBox.text = currentWeapon.name;
        priceTextBox.text = currentWeapon.cost.ToString();
        damageTextBox.text = currentWeapon.attack.ToString();
        ageTextBox.text = currentWeapon.age.ToString();

    }
}
