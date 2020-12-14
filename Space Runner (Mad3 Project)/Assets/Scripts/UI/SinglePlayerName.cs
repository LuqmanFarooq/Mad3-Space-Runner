using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SinglePlayerName : MonoBehaviour
{
    public InputField playerName;
    string pName;
    // saving player name to playerprefs
    public void SaveNames()
    {
        pName = playerName.text;
        
        PlayerPrefs.SetString("playerName", pName);
        
        PlayerPrefs.Save();
    }
}
