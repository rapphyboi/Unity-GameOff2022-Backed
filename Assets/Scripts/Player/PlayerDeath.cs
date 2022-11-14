using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    Animator playerAnimator;

    private void Start()
    {
        playerAnimator = GetComponent<Animator>();
    }
    public void OnLoseAllHealth()
    {
        playerAnimator.SetBool("isDead", true);
    }

    public void DeathAnimationEnd()
    {
        Destroy(gameObject);
        Destroy(FindObjectOfType<CollisionChild>().gameObject);
    }
}
