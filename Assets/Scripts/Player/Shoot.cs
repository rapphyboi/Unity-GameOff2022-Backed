using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] Projectile projectilePrefab;
    Animator playerAnimator;
    [SerializeField] Transform gun;


    private void Start()
    {
        playerAnimator = GetComponent<Animator>();
    }
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
        }
    }

   /* public void OnTriggerExit2DChild()
    {
        playerAnimator.SetBool("EnemyDetected", false);
    }

    public void OnTriggerStay2DChild()
    {
        playerAnimator.SetBool("EnemyDetected", true);
    }
*/
    public void ShootProjectile()
    {
        Debug.Log("Shooting Projectile");
        Instantiate(projectilePrefab, gun.position, Quaternion.identity);
    }
}
