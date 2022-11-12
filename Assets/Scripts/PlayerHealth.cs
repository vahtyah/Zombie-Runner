using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float health;

    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            print("cut");
        }
    }
}
