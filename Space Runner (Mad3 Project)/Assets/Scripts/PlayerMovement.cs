using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerMovement : MonoBehaviour
{
    // srtting the speed
    [SerializeField] float movementSpeed = 1f;
    [SerializeField] float turnSpeed = 50f;
    // for calculating distance
    //public Text distanceMoved;
    float distanceUnit = 0;
    // Transform Object
    Transform myTransform;

    private void Start()
    {
        InvokeRepeating("distance", 0, 10/ movementSpeed);
    }
    private void Awake()
    {
        myTransform = transform;
    }
   
    private void Update()
    {
        Turn();
        Thrust();
    }

    void Thrust()
    {
        // move the ship sorward
        transform.position += transform.forward * movementSpeed * Time.deltaTime;
    }

    void Turn() // turning ship left and right
    {
        float yaw = turnSpeed * Time.deltaTime * Input.GetAxis("Horizontal"); // how much to turn left or right
        float pitch = turnSpeed * Time.deltaTime * Input.GetAxis("Pitch"); // how much to bend left or right
                                                                              
        myTransform.Rotate(pitch,yaw,0);//pitch for the rotation on the x,rotation on y is yaw and 0 for the z
    }
    // encoprating text into this function
    void distance()
    {

        distanceUnit = distanceUnit + 1;

        EventManager.distanceMoved(distanceUnit);
    }
}
