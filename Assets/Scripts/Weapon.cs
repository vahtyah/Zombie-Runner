using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] Camera FPcamera;
    [SerializeField] float range = 100f;
    [SerializeField] float damage = 30f;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        if (Physics.Raycast(FPcamera.transform.position, FPcamera.transform.forward, out RaycastHit hit, range)){
            print(hit.transform.name);
            EnemyHealth target = hit.transform.GetComponent<EnemyHealth>();
            if (target) {
                target.TakeDamage(damage);
            }
        }
    }
}
