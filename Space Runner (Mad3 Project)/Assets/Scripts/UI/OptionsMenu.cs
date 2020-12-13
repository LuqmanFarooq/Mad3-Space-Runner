using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    public GameObject optionsPanel;
    public GameObject gameUi;

    public void ClickOptions()
    {
        optionsPanel.SetActive(true);
        gameUi.SetActive(false);
        Time.timeScale = 0f;
    }
    public void OnBackButton()
    {
        optionsPanel.SetActive(false);
        gameUi.SetActive(true);
        Time.timeScale = 1f;
    }

}
