using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] int damage;
    Animator animator;
    [SerializeField] Health playerOrTowerHealth;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        playerOrTowerHealth = collision.gameObject.GetComponent<Health>();
        animator.SetBool("isMoving", false);
        animator.SetBool("isAttacking", true);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        animator.SetBool("isMoving", true);
        animator.SetBool("isAttacking", false);
    }


    public void Attack(int damage)
    {
        playerOrTowerHealth.MinusCurrentHealth(damage); //SET FUNCTION AND DAMAGE IN ANIMATION EVENT
    }
}
