using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaneDetector : MonoBehaviour
{
    [SerializeField] Animator playerAnimator;
    [SerializeField] Shoot shoot;

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<EnemyMovement>())
        {
            playerAnimator.SetBool("EnemyDetected", false);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.GetComponent<EnemyMovement>())
        {
            playerAnimator.SetBool("EnemyDetected", true);
            shoot.enemyPos = collision.transform.position;
        }
    }
}

