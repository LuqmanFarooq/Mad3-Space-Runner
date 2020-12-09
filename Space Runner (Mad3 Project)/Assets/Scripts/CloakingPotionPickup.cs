using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloakingPotionPickup : MonoBehaviour
{
    public GameObject asteroid;
    public PlayerMovement playerMovement;

    //public Animation potionExplodeAnim;

    private void Awake()
    {
        // now we can talk to the playermovement script and access is method and variables
        playerMovement = GameObject.FindObjectOfType<PlayerMovement>();
    }
    // on collection of slow speed green potion the speed of the player slows down easy for him to maneuver and dodge the asteroids
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
           // calling the slowspeed method from playermovement script and changing speed
            playerMovement.slowSpeed(30f, 60f);
            // destroy that science/coin object
            Destroy(this.gameObject);
   
           Invoke("BacktoNormalSpeed", 10);
        }

        void BacktoNormalSpeed()
        {
            playerMovement.LevelUpSpeed();
        }
    }

    
    
    

}
