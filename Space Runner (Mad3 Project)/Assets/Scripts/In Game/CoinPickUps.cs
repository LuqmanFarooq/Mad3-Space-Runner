using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickUps : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            GameData.singleton.UpdateScore(50);
            // destroy that science/coin object
            Destroy(this.gameObject);

        }
    }

}
