using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaneParent : MonoBehaviour
{
    /*[SerializeField] LaneDetector enemyDetector;
    public LaneDetector EnemyDetector { get { return enemyDetector; } }*/

    [SerializeField] List<TowerShoot> towerShoots = new List<TowerShoot>();


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Enemy>())
        {
            foreach (TowerShoot towerShoot in towerShoots)
            {
                towerShoot.StopAttacking();
            }
        }

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Enemy>()) 
        { 
            if (towerShoots != null)
            {
                foreach (TowerShoot towerShoot in towerShoots)
                {
                    towerShoot.StartAttacking();
                }
            }
        }
    }

    

    public void AddToShootArray(TowerShoot towerShoot)
    {
        towerShoots.Add(towerShoot);
    }

    public void RemoveFromShootArray(TowerShoot towerShoot)
    {
        towerShoots.Remove(towerShoot);
    }
}
