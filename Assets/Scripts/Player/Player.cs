using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] HealthBar healthBar;
    Health health;

    PlayerDeath playerDeath;

    private void Start()
    {
        health = GetComponent<Health>();
        playerDeath = GetComponent<PlayerDeath>();
        healthBar.SetMaxHealth(health.MaxHealth);
    }

    private void Update()
    {

    }

    public void TookDamage()
    {
        healthBar.SetHealth(health.CurrentHealth);
        if (health.CurrentHealth <= 0)
        {
            playerDeath.OnLoseAllHealth();
        }
    }
}
