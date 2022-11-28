using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] float damage;
    Animator animator;
    Player player;

    private void Start()
    {
        animator = GetComponent<Animator>();
        player = FindObjectOfType<Player>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Projectile>())
        {
            Debug.Log("Got Hit By Projectile");
        }
        animator.SetBool("isMoving", false);
        animator.SetBool("isAttacking", true);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Projectile>())
        {
            Debug.Log("Got Hit By Projectile");
        }
        animator.SetBool("isMoving", true);
        animator.SetBool("isAttacking", false);
    }

    public void AttackPlayer(float damage)
    {
        player.TakeDamage(damage); //SET FUNCTION AND DAMAGE IN ANIMATION EVENT
    }
}
