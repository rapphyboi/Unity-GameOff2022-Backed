using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    [SerializeField] GameObject topLane;
    [SerializeField] GameObject middleLane;
    [SerializeField] GameObject bottomLane;

    Vector2 aim;

    public int laneCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        laneCounter = 0;
        
        topLane.GetComponent<Collider2D>().enabled = false;
        middleLane.GetComponent<Collider2D>().enabled = true;
        bottomLane.GetComponent<Collider2D>().enabled = false;
        topLane.GetComponentInChildren<SpriteRenderer>().enabled = false;
        middleLane.GetComponentInChildren<SpriteRenderer>().enabled = true;
        bottomLane.GetComponentInChildren<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        laneCounter = Mathf.Clamp(laneCounter, -1, 1);
        if(Input.GetKeyDown("w"))
        {
            laneCounter++;
        }
        else if(Input.GetKeyDown("s"))
        {
            laneCounter--;
        }
        AimToLane(laneCounter);
        Debug.Log(laneCounter);
    }

    void AimToLane(int laneCounter)
    {
        if(laneCounter == 1)
        {
            topLane.GetComponent<Collider2D>().enabled = true;
            middleLane.GetComponent<Collider2D>().enabled = false;
            bottomLane.GetComponent<Collider2D>().enabled = false;

            topLane.GetComponentInChildren<SpriteRenderer>().enabled = true;
            middleLane.GetComponentInChildren<SpriteRenderer>().enabled = false;
            bottomLane.GetComponentInChildren<SpriteRenderer>().enabled = false;
        }
        else if(laneCounter == -1)
        {
            topLane.GetComponent<Collider2D>().enabled = false;
            middleLane.GetComponent<Collider2D>().enabled = false;
            bottomLane.GetComponent<Collider2D>().enabled = true;

            topLane.GetComponentInChildren<SpriteRenderer>().enabled = false;
            middleLane.GetComponentInChildren<SpriteRenderer>().enabled = false;
            bottomLane.GetComponentInChildren<SpriteRenderer>().enabled = true;
        }
        else
        {
            topLane.GetComponent<Collider2D>().enabled = false;
            middleLane.GetComponent<Collider2D>().enabled = true;
            bottomLane.GetComponent<Collider2D>().enabled = false;

            topLane.GetComponentInChildren<SpriteRenderer>().enabled = false;
            middleLane.GetComponentInChildren<SpriteRenderer>().enabled = true;
            bottomLane.GetComponentInChildren<SpriteRenderer>().enabled = false;
        }
    }
}
