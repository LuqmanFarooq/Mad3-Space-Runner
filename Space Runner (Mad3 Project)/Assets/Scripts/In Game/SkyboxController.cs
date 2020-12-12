using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SkyboxController : MonoBehaviour
{
    public Material level2sky;
    public Material level3Sky;
    public GameObject level2Text;
    public GameObject level3Text;
    // Start is called before the first frame update
    void Start()
    {
        level2Text.SetActive(false);
        level3Text.SetActive(false);
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
            // checks if object is not destroyed
            if (level2Text != null)
            {
                // displays the level 3 text
                DisplayLevel2();
                Destroy(level2Text, 2);
            }
            
            
        }
        // checking if score is greater than or equal to 250 then change the sky box to show level change
        if (scr >= 250)
        {
            RenderSettings.skybox = level3Sky;
            // checks if object is not destroyed
            if (level3Text != null)
            {
                // displays the level 3 text
                DisplayLevel3();
                Destroy(level3Text, 2);
            }

        }
    }

    void DisplayLevel2()
    {
        level2Text.SetActive(true);

    }
    void DisplayLevel3()
    {
        level3Text.SetActive(true);
    }
}
