using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaneDetector : MonoBehaviour
{
    bool enemyDetected = false;
    public bool EnemyDetected { get { return enemyDetected; } }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Enemy>())
        {
            enemyDetected = true;
        }
    }
}

