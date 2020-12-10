using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlowPotionPickup : MonoBehaviour
{
    

    public SlowPickUpManager SlowPickUpManager;
    //public Animation potionExplodeAnim;
    private void Awake()
    {

        SlowPickUpManager = GameObject.FindObjectOfType<SlowPickUpManager>();

    }
  
    // on collection of slow speed green potion the speed of the player slows down easy for him to maneuver and dodge the asteroids
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            SlowPickUpManager.activateText.SetActive(true);
            // set the potionEnavl
            SlowPickUpManager.slowPotion = true;

            // destroy that scien object
            Destroy(this.gameObject);

            Invoke("HideActivated", 1);
            Invoke("DisplayDeactivate", 9);
            Invoke("HideDeactivate", 11);
            
        }

    }
    

  


}
