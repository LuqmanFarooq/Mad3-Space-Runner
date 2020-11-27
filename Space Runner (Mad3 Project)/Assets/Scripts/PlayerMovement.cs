using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // srtting the speed
    [SerializeField] float movementSpeed = 1f;
    [SerializeField] float turnSpeed = 50f;
    // Transform Object
    Transform myTransform;
    
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
}
