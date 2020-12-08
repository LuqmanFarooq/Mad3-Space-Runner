using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CoinRotation : MonoBehaviour
{
    Transform myTransform;
    Vector3 randomRotation;
    [SerializeField] float rotationOffset = 50f;
    static int score = 10;
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
    // checks for collision with the player and distroys the coin object that colides
   
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            coinPickup();
            // destroy that science/coin object
            Destroy(gameObject);
            
        }
    }

    public void coinPickup()
    {
        //adding 10 points to the score event
        EventManager.scorePoints(score);
    }

}
