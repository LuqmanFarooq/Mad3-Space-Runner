using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollowCam : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Vector3 defaultDistance = new Vector3(0f, 2f, -10f);
    [SerializeField] float distanceDamp = 10f;
    [SerializeField] float rotationDamp = 10f;


    Transform myTransform;

    private void Awake()
    {
        myTransform = transform;
    }

    // because its camera we are using LateUpdate instead of update
    private void LateUpdate()
    {
        // checking if target is not distroyed
        if (target != null)
        {
            // calcualting position where we want to move
            Vector3 toPosition = target.position + (target.rotation * defaultDistance);
            Vector3 currentPosition = Vector3.Lerp(myTransform.position, toPosition, distanceDamp * Time.deltaTime);
            myTransform.position = currentPosition;
            // calcualting position for rotation
            Quaternion toRotation = Quaternion.LookRotation(target.position - myTransform.position, target.up);
            Quaternion currentRotation = Quaternion.Slerp(myTransform.rotation, toRotation, rotationDamp * Time.deltaTime);
            myTransform.rotation = currentRotation;
        }
    }
}
