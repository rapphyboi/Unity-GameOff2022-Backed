using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    Animator playerAnimator;
    GameManager gameManager;
    GameOver gameOver;

    private void Start()
    {
        playerAnimator = GetComponent<Animator>();
        gameManager = FindObjectOfType<GameManager>();
        gameOver = FindObjectOfType<GameOver>();
    }
    public void OnLoseAllHealth()
    {
        playerAnimator.SetBool("isDead", true);
    }

    public void PlayDeathAudio()
    {
        FindObjectOfType<AudioManager>().Play("PlayerDeath");
        FindObjectOfType<AudioManager>().Stop("GameMusic");
    }

    public void DeathAnimationEnd() //EXECUTED IN DEATH ANIMATION OF PLAYER
    {
        Destroy(gameObject);
    }

    private void OnDestroy()
    {
        gameOver.EnableMenu();
        gameManager.GameOver();
    }
}
