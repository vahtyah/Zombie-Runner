using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitcher : MonoBehaviour
{
    [SerializeField] int currentWeapon = 0;

    void Start()
    {
        SetWeaponActive();
    }

    private void Update()
    {
        int previousWeapon = currentWeapon;

        ProcessKeyInput();
        ProcessScrollWhell();

        if(previousWeapon != currentWeapon) SetWeaponActive();
    }

    private void ProcessScrollWhell()
    {
        if(Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            currentWeapon++;
            if (currentWeapon >= transform.childCount)
                currentWeapon = 0;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            currentWeapon--;
            if (currentWeapon < 0)
                currentWeapon = transform.childCount - 1;
        }
    }

    private void ProcessKeyInput()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            currentWeapon++;
            if (currentWeapon >= transform.childCount)
                currentWeapon = 0;
        }
    }

    private void SetWeaponActive()
    {
        int weaponIndex = 0;

        foreach (Transform weapon in transform)
        {
            if (weaponIndex == currentWeapon)
            {
                weapon.gameObject.SetActive(true);
            }
            else
            {
                weapon.gameObject.SetActive(false);
            }
            weaponIndex++;
        }

    }
}
