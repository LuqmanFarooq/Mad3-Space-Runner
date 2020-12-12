using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public int numberOfCoinsOnAnAxis = 15;
    public int gridSpacing = 100;
    public GameObject coin;

    private void Start()
    {
        PlaceCoins();
    }

    void PlaceCoins()
    {
        for (int x = 0; x < numberOfCoinsOnAnAxis; x++)
        {
            for (int y = 0; y < numberOfCoinsOnAnAxis; y++)
            {
                for (int z = 0; z < numberOfCoinsOnAnAxis; z++)
                {
                    InstantiateCoins(x, y, z);
                }//z
            }//y
        }//x
    }//placeAsteroids

    void InstantiateCoins(int x, int y, int z)
    {
        Instantiate(coin,
            new Vector3(transform.position.x + (x * gridSpacing) + CoinsOffSet(),
            transform.position.y + (y * gridSpacing) + CoinsOffSet(),
            transform.position.z + (z * gridSpacing) + CoinsOffSet()),
            Quaternion.identity,
               transform);
    }

    float CoinsOffSet()
    {
        return Random.Range(-gridSpacing, gridSpacing);
    }
    
}
