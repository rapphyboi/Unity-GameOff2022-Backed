using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public GameObject scraps;
    public Transform startPos;
    private void OnDisable()
    {
        transform.position = startPos.position;
    }

    private void OnEnable()
    {
        GetComponent<Enemy>().currentHealth = GetComponent<Enemy>().maxHealth;
    }

    public void DropScrapsOnDeath()
    {
        Instantiate(scraps, transform.position, Quaternion.identity);
    }
}
