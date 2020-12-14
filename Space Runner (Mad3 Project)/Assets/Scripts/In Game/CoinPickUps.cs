using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickUps : MonoBehaviour
{
    public AudioClip coinPickSound;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(coinPickSound, gameObject.transform.position);
            GameData.singleton.UpdateScore(20);
            // destroy that science/coin object
            Destroy(this.gameObject);

        }
    }

}
