using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    [SerializeField]
    List<WeaponStats> weapons = new List<WeaponStats>();


    [SerializeField]
    GameObject weaponUIPrefab;


    [SerializeField]
    RectTransform UIRoot;

    // Start is called before the first frame update
    void Start()
    {
        float startY = -80.0f;
        foreach(WeaponStats weapon in weapons)
        {
            GameObject currentWeaponPanel = Instantiate<GameObject>(weaponUIPrefab);
            Vector3 position = new Vector3(100.0f, startY, 0.0f);
            currentWeaponPanel.transform.position = position;
            currentWeaponPanel.transform.SetParent(UIRoot,false);


            WeaponUIScript weaponUI = currentWeaponPanel.GetComponent<WeaponUIScript>();
            weaponUI.SetWeapon(weapon);

            startY -= 140.0f;
        }
    }

}
