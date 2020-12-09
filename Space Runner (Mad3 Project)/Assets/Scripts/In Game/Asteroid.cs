using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    Transform myTransform;
    Vector3 randomRotation;
    [SerializeField] float minScale = 2.4f;
    [SerializeField] float maxScale = 6f;
    [SerializeField] float rotationOffset = 50f;
   
    // Update is called once per frame
    private void Awake()
    {
        myTransform = transform;
    }

    void Start()
    {
        //randon size
        //initialze the scale
        Vector3 scale = Vector3.one;
        scale.x = Random.Range(minScale, maxScale);
        scale.y = Random.Range(minScale, maxScale);
        scale.z = Random.Range(minScale, maxScale);

        myTransform.localScale = scale;
        // randon rotation
        randomRotation.x = Random.Range(-rotationOffset, rotationOffset);
        randomRotation.y = Random.Range(-rotationOffset, rotationOffset);
        randomRotation.z = Random.Range(-rotationOffset, rotationOffset);
    }

    private void Update()
    {
        myTransform.Rotate(randomRotation * Time.deltaTime);
    }
}
