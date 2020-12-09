using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerMovement : MonoBehaviour
{
    public CloakingPotionPickup CloakingPotionPickup;
    // setting the speed
   public float movementSpeed = 50f;
   public float turnSpeed = 100f;
    // for calculating distance
    //public Text distanceMoved;
    float distanceUnit = 0;
    // Transform Object
    Transform myTransform;

    private void Start()
    {
        InvokeRepeating("distance", 0, 20/ movementSpeed);
    }
    private void Awake()
    {
        myTransform = transform;
        CloakingPotionPickup = GameObject.FindObjectOfType<CloakingPotionPickup>();

    }
   
    private void Update()
    {
        Turn();
        Thrust();
        LevelUpSpeed();
        
        
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

    // method to show increase in player as we procced to level 2
    public void LevelUpSpeed()
    {
        string levelUpScore;

        levelUpScore = GameData.singleton.science.text.ToString();
        int scr = int.Parse(levelUpScore);
        if (scr >= 150 && scr<250)
        {
            movementSpeed = 100f;
            turnSpeed = 110f;
        }
        if (scr >= 250)
        {
            movementSpeed = 125f;
            turnSpeed = 120f;
        }
    }
    public void slowSpeed(float movement,float turn)
    {
        movementSpeed = movement;
        turnSpeed = turn;
    }
    
}
