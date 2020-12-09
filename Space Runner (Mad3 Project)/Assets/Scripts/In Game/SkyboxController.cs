using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SkyboxController : MonoBehaviour
{
    public Material level2sky;
    public Material level3Sky;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Level2Up();
    }

    void Level2Up()
    {
        // a varaible to store score string
        string levelUpScore;
        // acessing the score 
        levelUpScore = GameData.singleton.science.text.ToString();
        // parsing score as int to store in scr
       int  scr = int.Parse(levelUpScore);
        // checking if score is greater than or equal to 150 then change the sky box to show level change
        if(scr >= 150)
        {
            RenderSettings.skybox = level2sky;
        }
        // checking if score is greater than or equal to 250 then change the sky box to show level change
        if (scr >= 250)
        {
            RenderSettings.skybox = level3Sky;
        }
    }
}
