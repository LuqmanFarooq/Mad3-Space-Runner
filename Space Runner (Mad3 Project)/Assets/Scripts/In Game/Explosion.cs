using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Explosion : MonoBehaviour
{
    public GameObject explosion;
    public bool isPlayerDead = false;
    void IveBeenHit(Vector3 pos)
    {
        GameObject go = Instantiate(explosion, pos, Quaternion.identity, transform) as GameObject;
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

            PlayerPrefs.SetInt("lastscore", PlayerPrefs.GetInt("score"));
            if(PlayerPrefs.HasKey("highScore"))
            {
                int hs = PlayerPrefs.GetInt("highScore");
                if(hs < PlayerPrefs.GetInt("score"))
                {
                    PlayerPrefs.SetInt("highScore", PlayerPrefs.GetInt("score"));
                }
                else
                {
                    PlayerPrefs.SetInt("highScore", hs);
                }
            }
        }

    }// oncollision

    private void Update()
    {
        if(isPlayerDead)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
