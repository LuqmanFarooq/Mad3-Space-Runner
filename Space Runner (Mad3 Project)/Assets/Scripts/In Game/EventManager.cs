using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void distanceDelegate(float amt);
    public static distanceDelegate onDistanceMoved;

    public static void distanceMoved(float distance)
    {
        if (onDistanceMoved != null)
            onDistanceMoved(distance);
    }

}
