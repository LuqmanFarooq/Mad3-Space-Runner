using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DisplayStats : MonoBehaviour
{
    public Text lastScore;
    public Text highestScore;

    private void OnEnable()
    {
        if(PlayerPrefs.HasKey("lastscore"))
        {
            lastScore.text = "Last Score: " + PlayerPrefs.GetInt("lastscore");
        }
        else
        {
            lastScore.text = "Last Score: 0";
        }
        // for highest score
        if (PlayerPrefs.HasKey("highScore"))
        {
            highestScore.text = "High Score: " + PlayerPrefs.GetInt("highScore");
        }
        else
        {
            highestScore.text = "High Score: 0";
        }
    }

}
