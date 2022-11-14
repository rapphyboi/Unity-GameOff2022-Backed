using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float maxHealth = 100f;
    [SerializeField] float currentHealth;
    PlayerDeath playerDeath;

    [SerializeField] HealthBar healthBar;

    private void Start()
    {
        playerDeath = GetComponent<PlayerDeath>();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if(currentHealth == 0)
        {
            playerDeath.OnLoseAllHealth();
        }
    }
}
