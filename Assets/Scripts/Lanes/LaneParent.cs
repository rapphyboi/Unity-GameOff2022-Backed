using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaneParent : MonoBehaviour
{
    [SerializeField] LaneDetector enemyDetector;
    public LaneDetector EnemyDetector { get { return enemyDetector; } }
}
