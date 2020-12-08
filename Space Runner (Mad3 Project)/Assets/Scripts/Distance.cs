using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Distance : MonoBehaviour
{
    //Text highScoreText;
    public Text distanceMoved;
    float distance;
    int highScore;

    private void Start()
    {
       // LoadHiScore();
        ResetDistance();
        EventManager.onDistanceMoved += AddDistance;
    }
    //  for highscore we are saving it to the playerprefs 
    void LoadHiScore()
    {
        highScore = PlayerPrefs.GetInt("highScore", 0);
    }

    // resets the score to zero
    void ResetDistance()
    {
        distance = 0;
        DisplayDistance();
    }

    void AddDistance(float amount)
    {
        distance += amount;
        DisplayDistance();
    }

    void DisplayDistance()
    {
        distanceMoved.text = distance.ToString();
    }


    // checks for new highscore
   /* void CheckNewHighScore()
    {
        // if we have new high score we save it and update display
        if (distance > highScore)
        {
            PlayerPrefs.SetInt("highScore", distance);
            DisplayHighScore();
        }
    }
   */
    // updates the display in our gui
    void DisplayHighScore()
    {
        // highScoreText.text = highScore.ToString();
    }
}
