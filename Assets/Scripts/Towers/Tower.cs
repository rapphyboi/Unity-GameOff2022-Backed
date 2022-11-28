using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] int damage;
    [SerializeField] int health;
    LaneDetector enemyDetector;

    private void Start()
    {
        enemyDetector = GetComponentInParent<LaneParent>().EnemyDetector;
    }

    private void Update()
    {
        if (enemyDetector.EnemyDetected)
        {

        }
    }
}
