using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SinglePlayerGameOver : MonoBehaviour
{
    string playerName;
    private void Awake()
    {
        playerName = PlayerPrefs.GetString("playerName");
    }

    public Text PlayerScore;
    public Text breakScore;

    private void OnEnable()
    {
        if (PlayerPrefs.GetInt("PlayerScore") >= PlayerPrefs.GetInt("highScore"))
        {
            PlayerScore.text = playerName + " Scored : " + PlayerPrefs.GetInt("PlayerScore");
        
            breakScore.text = "Congratulations! " + playerName + " you acheieved HighScore";
        }
        else if (PlayerPrefs.GetInt("PlayerScore") < PlayerPrefs.GetInt("highScore"))
        {
            PlayerScore.text = playerName + " Scored : " + PlayerPrefs.GetInt("PlayerScore");
            breakScore.text = "Couldn't Break the highScore Record which is : " + PlayerPrefs.GetInt("highScore");
        }
       

    }
}
