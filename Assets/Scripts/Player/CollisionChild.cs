using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionChild : MonoBehaviour
{
    [SerializeField] Transform parent;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<EnemyMovement>())
        {
            parent.GetComponent<PlayerDeath>().PlayerReached();
        }
    }
}
