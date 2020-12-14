using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerMovementMulti : MonoBehaviour
{
    public SlowPickUpManager PickUpManager;
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
        PickUpManager = GameObject.FindObjectOfType<SlowPickUpManager>();
        // settting score to zero for 2nd player
        GameData.singleton.score = 0;
    }
   
    private void Update()
    {
        Turn();
        Thrust();
        LevelUpSpeed();
        
        SlowPotion();
        
    }
    void PotionFalse()
    {
        PickUpManager.slowPotion = false;
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
        if (scr < 140)
        {
            movementSpeed = 50f;
            turnSpeed = 100f;
        }
        if (scr >= 140 && scr<260)
        {
            movementSpeed = 100f;
            turnSpeed = 110f;
        }
        if (scr >= 260)
        {
            movementSpeed = 125f;
            turnSpeed = 120f;
        }
        if (scr >= 300)
        {
            movementSpeed = 135f;
            turnSpeed = 120f;
        }
    }
    public void slowSpeed(float movement,float turn)
    {
        movementSpeed = movement;
        turnSpeed = turn;
    }
    
    void SlowPotion()
    {
        // if palyer collects slow green potion then changing the speed
        if (PickUpManager.slowPotion == true)
        {
            slowSpeed(40f, 60f);
            // setting the bool back to false after 10 seconds
            Invoke("PotionFalse", 10);
        }
        // changing the speed of player back to normal after slowpotion 
        else if (PickUpManager.slowPotion == false)
        {
            LevelUpSpeed();
        }
    }
}
