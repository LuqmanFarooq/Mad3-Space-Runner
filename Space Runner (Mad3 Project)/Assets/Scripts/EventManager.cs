using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void scorePointsDelegate(int amt);
    public static scorePointsDelegate onScorePoints;

    public delegate void distanceDelegate(float amt);
    public static distanceDelegate onDistanceMoved;

    public static void scorePoints(int score)
    {
        if (onScorePoints != null)
            onScorePoints(score);
    }

    public static void distanceMoved(float distance)
    {
        if (onDistanceMoved != null)
            onDistanceMoved(distance);
    }

}
