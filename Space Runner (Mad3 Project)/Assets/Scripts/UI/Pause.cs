using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject PausePanel;
    public GameObject gameUi;
    static bool GameIsPaused = false;
    // pausing the game
    public void ClickPause()
    {
        PausePanel.SetActive(true);
        gameUi.SetActive(false);
        Time.timeScale = 0;
        GameIsPaused = true;
    }
    //resuming the game
    public void Resume()
    {
        PausePanel.SetActive(false);
        gameUi.SetActive(true);
        Time.timeScale = 1;
        GameIsPaused = false;
    }
    void Update()
    {
        // pause and resume with esc button
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                ClickPause();
            }
        }
    }
}
