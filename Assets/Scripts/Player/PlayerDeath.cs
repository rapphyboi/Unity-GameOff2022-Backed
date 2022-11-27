using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField] float gameOverScreenDelay = 3f;

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
        Destroy(FindObjectOfType<CollisionChild>().gameObject);
        Destroy(gameObject);
    }

    IEnumerator ShowGameOverScreen()
    {
        yield return new WaitForSeconds(gameOverScreenDelay);
    }
}
