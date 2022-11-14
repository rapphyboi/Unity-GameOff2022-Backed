using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] Animator blobAnimator;
    Player player;

    private void Start()
    {
        player = FindObjectOfType<Player>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<CollisionChild>())
        {
            blobAnimator.SetBool("isMoving", false);
            blobAnimator.SetBool("isAttacking", true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<CollisionChild>())
        {
            blobAnimator.SetBool("isMoving", true);
            blobAnimator.SetBool("isAttacking", false);
        }
    }

    public void AttackPlayer(float damage)
    {
        player.TakeDamage(damage); //SET FUNCTION AND DAMAGE IN ANIMATION EVENT
    }
}
