using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerPlacer : MonoBehaviour
{
    [SerializeField] Tower tower;
    Canvas towerCanvas;
    Tile tileParent;
    Animator animator;

    private void Start()
    {
        towerCanvas = GetComponentInParent<Canvas>();
        animator = GetComponentInParent<Animator>();
        tileParent = GetComponentInParent<Tile>();
    }

    private void OnMouseDown()
    {
        PlaceTower();
    }

    void PlaceTower()
    {
        Tower myTower = Instantiate(tower, tileParent.transform.position, Quaternion.identity);
        myTower.transform.parent = tileParent.transform;
        animator.SetBool("isSelected", false);
        towerCanvas.enabled = false;
    }
}
