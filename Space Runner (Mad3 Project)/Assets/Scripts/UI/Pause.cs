using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject PausePanel;
    public GameObject gameUi;
    
    public void ClickPause()
    {
        PausePanel.SetActive(true);
        gameUi.SetActive(false);
        Time.timeScale = 0;
    }
    public void Resume()
    {
        PausePanel.SetActive(false);
        gameUi.SetActive(true);
        Time.timeScale = 1;
    }
}
