using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tile : MonoBehaviour
{
    public SpriteRenderer border;
    public Canvas towerCanvas;
    [SerializeField] TileManager tileManager;
    [SerializeField] Animator animator;

    GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        tileManager = FindObjectOfType<TileManager>();
    }

    private void OnMouseOver()
    {
        if (gameManager.IsPaused == true)
        {
            Debug.Log("Game is Paused");
        }
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                foreach (Tile tile in tileManager.tiles)
                {
                    tile.border.enabled = false;
                    tile.towerCanvas.enabled = false;
                    tile.animator.SetBool("isSelected", false);
                }
                FindObjectOfType<AudioManager>().Play("TowerSelect");
                border.enabled = true;
                towerCanvas.enabled = true;
                animator.SetBool("isSelected", true);
            }
        }
    }
    private void Update()
    {
        if (gameManager.IsPaused == true)
        {
            Debug.Log("Game is Paused");
        }
        else
        {
            if (Input.GetMouseButtonDown(1))
            {
                FindObjectOfType<AudioManager>().Play("TowerDeselect");
                border.enabled = false;
                towerCanvas.enabled = false;
                animator.SetBool("isSelected", false);
            }
        }
    }
}
