using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CoinRotation : MonoBehaviour
{
    Transform myTransform;
    Vector3 randomRotation;
    [SerializeField] float rotationOffset = 50f;
    private void Awake()
    {
        myTransform = transform;
    }

    void Start()
    {
       
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
