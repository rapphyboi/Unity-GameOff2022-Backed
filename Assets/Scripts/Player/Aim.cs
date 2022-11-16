using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{


    int laneCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        laneCounter = 0;
        SecondLaneActivate();
    }

    // Update is called once per frame
    void Update()
    {
        laneCounter = Mathf.Clamp(laneCounter, -2, 1);
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
            FirstLaneActivate();
        }
        else if(laneCounter == 0)
        {
            SecondLaneActivate();
        }
        else if(laneCounter == -1)
        {
            ThirdLaneActivate();
        }
        else if(laneCounter == -2)
        {
            FourthLaneActivate();
        }
    }

    void FirstLaneActivate()
    {
        transform.position = new Vector2(0, 1.5f);

    }
    void SecondLaneActivate()
    {
        transform.position = new Vector2(0, 0.5f);

    }
    void ThirdLaneActivate()
    {
        transform.position = new Vector2(0, -0.5f);

    }
    void FourthLaneActivate()
    {
        transform.position = new Vector2(0, -1.5f);

    }
}
