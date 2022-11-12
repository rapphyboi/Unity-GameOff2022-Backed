using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] Projectile projectilePrefab;
    [SerializeField] Transform gun;
    Projectile projectile;
    public void ShootProjectile()
    {
        Debug.Log("Shooting Projectile");
        projectile = Instantiate(projectilePrefab, gun.position, Quaternion.identity);
    }
}
