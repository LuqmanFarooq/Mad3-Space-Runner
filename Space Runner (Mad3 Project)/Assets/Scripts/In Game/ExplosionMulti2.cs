using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExplosionMulti2 : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject explosionMulti;
    public bool isPlayerDead = false;
    void IveBeenHit(Vector3 pos)
    {
        GameObject go = Instantiate(explosionMulti, pos, Quaternion.identity, transform) as GameObject;
        Destroy(go, 6f);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Asteroid") && !isPlayerDead)
        {
            foreach (ContactPoint contact in collision.contacts)
                IveBeenHit(contact.point);
            Destroy(gameObject, 2);
            isPlayerDead = true;
            // setting the last score to the playerprefs to dispay in stats
            PlayerPrefs.SetInt("lastscore", PlayerPrefs.GetInt("score"));
            // settign player 2 Score
            PlayerPrefs.SetInt("player2Score", PlayerPrefs.GetInt("score"));
            // comparing the and setting the highscore in playerprefs
            int hs = PlayerPrefs.GetInt("highScore");
            if (hs <= PlayerPrefs.GetInt("score"))
            {
                PlayerPrefs.SetInt("highScore", PlayerPrefs.GetInt("score"));
            }
            else
            {
                PlayerPrefs.SetInt("highScore", hs);
            }

        }

    }// oncollision

    private void Update()
    {
        if (isPlayerDead)
        {
            gameOverPanel.SetActive(true);
        }
    }
    
}

