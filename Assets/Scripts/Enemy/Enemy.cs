using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float maxHealth = 20f;
    public float currentHealth;


    private void Start()
    {
        currentHealth = maxHealth;
    }
    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            GetComponent<EnemyDeath>().DropScrapsOnDeath();
            gameObject.SetActive(false);
        }
    }
}
