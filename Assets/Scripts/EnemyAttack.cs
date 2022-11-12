using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    PlayerHealth target;
    [SerializeField] float damage = 40f;

    private void Awake()
    {
        target = FindObjectOfType<PlayerHealth>();
    }

    public void AttackHitEven()
    {
        if (target == null) return;
        target.TakeDamage(damage);
        print("bang bang");
    }
}
