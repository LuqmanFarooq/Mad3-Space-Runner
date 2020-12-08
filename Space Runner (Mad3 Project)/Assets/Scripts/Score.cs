using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    //Text highScoreText;
    public Text scoreText;
    int score;
    int highScore;

    private void Start()
    {
        LoadHiScore();
        ResetScore();
        EventManager.onScorePoints += AddScore;
    }
    //  for highscore we are saving it to the playerprefs 
    void LoadHiScore()
    {
       highScore =  PlayerPrefs.GetInt("highScore", 0);
    }

    // resets the score to zero
    void ResetScore()
    {
        score = 0;
        DisplayScore();
    }

    void AddScore(int amount)
    {
        score += amount;
        DisplayScore();
    }

    void DisplayScore()
    {
        scoreText.text = score.ToString();
    }


    // checks for new highscore
    void CheckNewHighScore()
    {
        // if we have new high score we save it and update display
        if (score > highScore)
        {
            PlayerPrefs.SetInt("highScore", score);
            DisplayHighScore();
        }
    }

    // updates the display in our gui
    void DisplayHighScore()
    {
       // highScoreText.text = highScore.ToString();
    }
}
