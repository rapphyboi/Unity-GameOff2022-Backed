using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public GameObject scraps;
    public Transform startPos;
    private void OnDisable()
    {
        transform.position = startPos.position;
        Debug.Log("dead"); 
    }

    private void OnEnable()
    {
        //transform.position = startPos.position;
    }
}
