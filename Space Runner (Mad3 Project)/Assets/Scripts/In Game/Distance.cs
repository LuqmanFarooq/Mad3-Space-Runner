using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Distance : MonoBehaviour
{
    //DistanceText;
    public Text distanceMoved;
    float distance;
    int highScore;

    private void Start()
    {
        ResetDistance();
        EventManager.onDistanceMoved += AddDistance;
    }
    // resets the distance to zero
    void ResetDistance()
    {
        distance = 0;
        DisplayDistance();
    }

    void AddDistance(float amount)
    {
        distance += amount;
        DisplayDistance();
    }

    void DisplayDistance()
    {
        if(distanceMoved!=null)
        distanceMoved.text = distance.ToString();
    }
}
