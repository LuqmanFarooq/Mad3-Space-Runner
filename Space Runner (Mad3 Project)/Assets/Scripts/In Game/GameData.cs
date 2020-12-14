using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameData : MonoBehaviour
{
    public static GameData singleton;
    public Text science = null;
    public bool player2Turn = false;
    public int score = 0;
    private void Awake()
    {
        GameObject[] gd = GameObject.FindGameObjectsWithTag("gamedata");
        // if there exists duplicates of this gameobject it destroys them
        if (gd.Length > 1)
        {
            Destroy(this.gameObject);
        }
        // doesn't destroy the gameobject
        DontDestroyOnLoad(this.gameObject);
        singleton = this;
        PlayerPrefs.SetInt("score", 0);
        
    }
    
    public void UpdateScore(int s)
    {
        score += s;
        PlayerPrefs.SetInt("score", score);
        if (science != null)
            science.text = "" + score;
    }
    
    
}
