using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void SinglePlayerGame ()
    {
        SceneManager.LoadScene("Level123");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void MultiPlayer1Game()
    {
        SceneManager.LoadScene("MultiPlayer1");
    }
    public void MultiPlayer2Game()
    {
        SceneManager.LoadScene("MultiPlayer2");
        GameData.singleton.player2Turn = true;
    }
    public void QuitGame ()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
    public void backtoMain()
    {
        SceneManager.LoadScene("MainMenu");

    }
}
