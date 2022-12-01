using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] int damage;
    [SerializeField] int cost = 5;
    public int Cost { get { return cost; } }

    Health health;

    private void Start()
    {
        health = GetComponent<Health>();
    }


    public void TookDamage()
    {
        if (health.CurrentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
