using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    [SerializeField] Collider2D top;
    [SerializeField] Collider2D mid;
    [SerializeField] Collider2D bottom;

    int laneCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        laneCounter = 0;
        MidLaneActivate();
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

            TopLaneActivate();
        }
        else if(laneCounter == -1)
        {
            BottomLaneActivate();
        }
        else
        {
            MidLaneActivate();
        }
    }

    void TopLaneActivate()
    {
        transform.position = new Vector2(0, 1.5f);
        top.enabled = true;
        mid.enabled = false;
        bottom.enabled = false;
    }
    void MidLaneActivate()
    {
        transform.position = new Vector2(0, 0);
        top.enabled = false;
        mid.enabled = true;
        bottom.enabled = false;
    }
    void BottomLaneActivate()
    {
        transform.position = new Vector2(0, -1.5f);
        top.enabled = false;
        mid.enabled = false;
        bottom.enabled = true;
    }
}
